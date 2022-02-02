
using Exam01.Shared.MessagePackObjects;
using MagicOnion;

using System.Threading.Tasks;
using UnityEngine;

namespace Exam01.Shared.Hubs
{
    public interface IExamHub : IStreamingHub<IExamHub, IExamHubReceiver>
    {
        Task JoinAsync(Player player);
        Task LeaveAsync();
        Task SendMessageAsync(string message);
        Task MovePositionAsync(Vector3 position);
    }

    public interface IExamHubReceiver
    {
        void OnJoin(string name);
        void OnLeave(string name);
        void OnSendMessage(string name, string message);
        void OnMovePosition(Player player);
    }
}
