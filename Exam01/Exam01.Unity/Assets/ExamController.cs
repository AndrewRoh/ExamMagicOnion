using Exam01.Shared.Services;
using Grpc.Core;
using MagicOnion.Client;
using UnityEngine;

public class ExamController : MonoBehaviour
{
    private Channel channel;
    private IExamService examService;

    // Start is called before the first frame update
    void Start()
    {
        channel = new Channel("127.0.0.1:12345", ChannelCredentials.Insecure);
        examService = MagicOnionClient.Create<IExamService>(channel);
        ExamServiceTest(5, 71);
    }

    async void OnDestroy()
    {
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


}
