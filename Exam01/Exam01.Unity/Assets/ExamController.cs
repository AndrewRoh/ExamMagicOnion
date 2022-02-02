using Exam01.Shared.Hubs;
using Exam01.Shared.MessagePackObjects;
using Exam01.Shared.Services;
using Grpc.Core;
using MagicOnion.Client;
using UnityEngine;

public class ExamController : MonoBehaviour, IExamHubReceiver
{
    private Channel channel;
    private IExamService examService;
    private IExamHub examHub;

    // Start is called before the first frame update
    void Start()
    {
        channel = new Channel("127.0.0.1:12345", ChannelCredentials.Insecure);
        examService = MagicOnionClient.Create<IExamService>(channel);
        //ExamServiceTest(5, 71);
        examHub = StreamingHubClient.Connect<IExamHub, IExamHubReceiver>(channel, this);
        ExamHubTest();
    }

    async void OnDestroy()
    {
        await examHub.DisposeAsync();
        await channel.ShutdownAsync();
    }

    async void ExamServiceTest(int x, int y)
    {
        var sumResult = await examService.SumAsync(x, y);
        Debug.Log($"{nameof(sumResult)}: {sumResult}");

        var productResult = await examService.ProductAsync(x, y);
        Debug.Log($"{nameof(productResult)}: {productResult}");
    }

    // Update is called once per frame
    void Update()
    {

    }

    async void ExamHubTest()
    {
        var player = new Player
        {
            Name = "Minami",
            Position = new Vector3(0, 0, 0),
            Rotation = new Quaternion(0, 0, 0, 0)
        };

        await this.examHub.JoinAsync(player);

        await this.examHub.SendMessageAsync("안녕하세요!");

        player.Position = new Vector3(1, 0, 0);
        await this.examHub.MovePositionAsync(player.Position);

        await this.examHub.LeaveAsync();
    }



    public void OnJoin(string name)
    {
        Debug.Log($"{name} OnJoin");
    }

    public void OnLeave(string name)
    {
        Debug.Log($"{name} OnLeave");
    }

    public void OnSendMessage(string name, string message)
    {
        Debug.Log($"{name} : {message}");
    }

    public void OnMovePosition(Player player)
    {
        Debug.Log($"{player.Name} OnMovePosition");
    }
}
