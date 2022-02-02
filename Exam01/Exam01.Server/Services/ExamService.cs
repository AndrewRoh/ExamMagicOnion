using Exam01.Shared.Services;
using MagicOnion;
using MagicOnion.Server;

namespace Exam01.Server.Services
{
    public class ExamService : ServiceBase<IExamService>, IExamService
    {
        public UnaryResult<int> SumAsync(int x, int y)
        {
            return UnaryResult(x + y);
        }

        public UnaryResult<int> ProductAsync(int x, int y)
        {
            return UnaryResult(x * y);
        }
    }
}
