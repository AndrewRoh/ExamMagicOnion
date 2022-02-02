using MagicOnion;

namespace Exam01.Shared.Services
{
    public interface IExamService : IService<IExamService>
    {
        UnaryResult<int> SumAsync(int x, int y);
        UnaryResult<int> ProductAsync(int x, int y);
    }
}