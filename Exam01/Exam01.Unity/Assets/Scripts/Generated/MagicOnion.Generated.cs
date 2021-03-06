// <auto-generated />
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace MagicOnion
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::MagicOnion;
    using global::MagicOnion.Client;

    public static partial class MagicOnionInitializer
    {
        static bool isRegistered = false;

        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Register()
        {
            if(isRegistered) return;
            isRegistered = true;

            MagicOnionClientRegistry<Exam01.Shared.Services.IExamService>.Register((x, y, z) => new Exam01.Shared.Services.ExamServiceClient(x, y, z));

            StreamingHubClientRegistry<Exam01.Shared.Hubs.IExamHub, Exam01.Shared.Hubs.IExamHubReceiver>.Register((a, _, b, c, d, e) => new Exam01.Shared.Hubs.ExamHubClient(a, b, c, d, e));
        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace MagicOnion.Resolvers
{
    using System;
    using MessagePack;

    public class MagicOnionResolver : global::MessagePack.IFormatterResolver
    {
        public static readonly global::MessagePack.IFormatterResolver Instance = new MagicOnionResolver();

        MagicOnionResolver()
        {

        }

        public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> formatter;

            static FormatterCache()
            {
                var f = MagicOnionResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                }
            }
        }
    }

    internal static class MagicOnionResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static MagicOnionResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(2)
            {
                {typeof(global::MagicOnion.DynamicArgumentTuple<int, int>), 0 },
                {typeof(global::MagicOnion.DynamicArgumentTuple<string, string>), 1 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key))
            {
                return null;
            }

            switch (key)
            {
                case 0: return new global::MagicOnion.DynamicArgumentTupleFormatter<int, int>(default(int), default(int));
                case 1: return new global::MagicOnion.DynamicArgumentTupleFormatter<string, string>(default(string), default(string));
                default: return null;
            }
        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace Exam01.Shared.Services {
    using System;
    using MagicOnion;
    using MagicOnion.Client;
    using Grpc.Core;
    using MessagePack;

    [Ignore]
    public class ExamServiceClient : MagicOnionClientBase<global::Exam01.Shared.Services.IExamService>, global::Exam01.Shared.Services.IExamService
    {
        static readonly Method<byte[], byte[]> SumAsyncMethod;
        static readonly Func<RequestContext, ResponseContext> SumAsyncDelegate;
        static readonly Method<byte[], byte[]> ProductAsyncMethod;
        static readonly Func<RequestContext, ResponseContext> ProductAsyncDelegate;

        static ExamServiceClient()
        {
            SumAsyncMethod = new Method<byte[], byte[]>(MethodType.Unary, "IExamService", "SumAsync", MagicOnionMarshallers.ThroughMarshaller, MagicOnionMarshallers.ThroughMarshaller);
            SumAsyncDelegate = _SumAsync;
            ProductAsyncMethod = new Method<byte[], byte[]>(MethodType.Unary, "IExamService", "ProductAsync", MagicOnionMarshallers.ThroughMarshaller, MagicOnionMarshallers.ThroughMarshaller);
            ProductAsyncDelegate = _ProductAsync;
        }

        ExamServiceClient()
        {
        }

        public ExamServiceClient(CallInvoker callInvoker, MessagePackSerializerOptions serializerOptions, IClientFilter[] filters)
            : base(callInvoker, serializerOptions, filters)
        {
        }

        protected override MagicOnionClientBase<IExamService> Clone()
        {
            var clone = new ExamServiceClient();
            clone.host = this.host;
            clone.option = this.option;
            clone.callInvoker = this.callInvoker;
            clone.serializerOptions = this.serializerOptions;
            clone.filters = filters;
            return clone;
        }

        public new IExamService WithHeaders(Metadata headers)
        {
            return base.WithHeaders(headers);
        }

        public new IExamService WithCancellationToken(System.Threading.CancellationToken cancellationToken)
        {
            return base.WithCancellationToken(cancellationToken);
        }

        public new IExamService WithDeadline(System.DateTime deadline)
        {
            return base.WithDeadline(deadline);
        }

        public new IExamService WithHost(string host)
        {
            return base.WithHost(host);
        }

        public new IExamService WithOptions(CallOptions option)
        {
            return base.WithOptions(option);
        }
   
        static ResponseContext _SumAsync(RequestContext __context)
        {
            return CreateResponseContext<DynamicArgumentTuple<int, int>, int>(__context, SumAsyncMethod);
        }

        public global::MagicOnion.UnaryResult<int> SumAsync(int x, int y)
        {
            return InvokeAsync<DynamicArgumentTuple<int, int>, int>("IExamService/SumAsync", new DynamicArgumentTuple<int, int>(x, y), SumAsyncDelegate);
        }
        static ResponseContext _ProductAsync(RequestContext __context)
        {
            return CreateResponseContext<DynamicArgumentTuple<int, int>, int>(__context, ProductAsyncMethod);
        }

        public global::MagicOnion.UnaryResult<int> ProductAsync(int x, int y)
        {
            return InvokeAsync<DynamicArgumentTuple<int, int>, int>("IExamService/ProductAsync", new DynamicArgumentTuple<int, int>(x, y), ProductAsyncDelegate);
        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace Exam01.Shared.Hubs {
    using Grpc.Core;
    using Grpc.Core.Logging;
    using MagicOnion;
    using MagicOnion.Client;
    using MessagePack;
    using System;
    using System.Threading.Tasks;

    [Ignore]
    public class ExamHubClient : StreamingHubClientBase<global::Exam01.Shared.Hubs.IExamHub, global::Exam01.Shared.Hubs.IExamHubReceiver>, global::Exam01.Shared.Hubs.IExamHub
    {
        static readonly Method<byte[], byte[]> method = new Method<byte[], byte[]>(MethodType.DuplexStreaming, "IExamHub", "Connect", MagicOnionMarshallers.ThroughMarshaller, MagicOnionMarshallers.ThroughMarshaller);

        protected override Method<byte[], byte[]> DuplexStreamingAsyncMethod { get { return method; } }

        readonly global::Exam01.Shared.Hubs.IExamHub __fireAndForgetClient;

        public ExamHubClient(CallInvoker callInvoker, string host, CallOptions option, MessagePackSerializerOptions serializerOptions, ILogger logger)
            : base(callInvoker, host, option, serializerOptions, logger)
        {
            this.__fireAndForgetClient = new FireAndForgetClient(this);
        }
        
        public global::Exam01.Shared.Hubs.IExamHub FireAndForget()
        {
            return __fireAndForgetClient;
        }

        protected override void OnBroadcastEvent(int methodId, ArraySegment<byte> data)
        {
            switch (methodId)
            {
                case -1297457280: // OnJoin
                {
                    var result = MessagePackSerializer.Deserialize<string>(data, serializerOptions);
                    receiver.OnJoin(result); break;
                }
                case 532410095: // OnLeave
                {
                    var result = MessagePackSerializer.Deserialize<string>(data, serializerOptions);
                    receiver.OnLeave(result); break;
                }
                case -552695459: // OnSendMessage
                {
                    var result = MessagePackSerializer.Deserialize<DynamicArgumentTuple<string, string>>(data, serializerOptions);
                    receiver.OnSendMessage(result.Item1, result.Item2); break;
                }
                case -114453294: // OnMovePosition
                {
                    var result = MessagePackSerializer.Deserialize<global::Exam01.Shared.MessagePackObjects.Player>(data, serializerOptions);
                    receiver.OnMovePosition(result); break;
                }
                default:
                    break;
            }
        }

        protected override void OnResponseEvent(int methodId, object taskCompletionSource, ArraySegment<byte> data)
        {
            switch (methodId)
            {
                case -733403293: // JoinAsync
                {
                    var result = MessagePackSerializer.Deserialize<Nil>(data, serializerOptions);
                    ((TaskCompletionSource<Nil>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case 1368362116: // LeaveAsync
                {
                    var result = MessagePackSerializer.Deserialize<Nil>(data, serializerOptions);
                    ((TaskCompletionSource<Nil>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case -601690414: // SendMessageAsync
                {
                    var result = MessagePackSerializer.Deserialize<Nil>(data, serializerOptions);
                    ((TaskCompletionSource<Nil>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case 1105294121: // MovePositionAsync
                {
                    var result = MessagePackSerializer.Deserialize<Nil>(data, serializerOptions);
                    ((TaskCompletionSource<Nil>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                default:
                    break;
            }
        }
   
        public global::System.Threading.Tasks.Task JoinAsync(global::Exam01.Shared.MessagePackObjects.Player player)
        {
            return WriteMessageWithResponseAsync<global::Exam01.Shared.MessagePackObjects.Player, Nil>(-733403293, player);
        }

        public global::System.Threading.Tasks.Task LeaveAsync()
        {
            return WriteMessageWithResponseAsync<Nil, Nil>(1368362116, Nil.Default);
        }

        public global::System.Threading.Tasks.Task SendMessageAsync(string message)
        {
            return WriteMessageWithResponseAsync<string, Nil>(-601690414, message);
        }

        public global::System.Threading.Tasks.Task MovePositionAsync(global::UnityEngine.Vector3 position)
        {
            return WriteMessageWithResponseAsync<global::UnityEngine.Vector3, Nil>(1105294121, position);
        }


        class FireAndForgetClient : global::Exam01.Shared.Hubs.IExamHub
        {
            readonly ExamHubClient __parent;

            public FireAndForgetClient(ExamHubClient parentClient)
            {
                this.__parent = parentClient;
            }

            public global::Exam01.Shared.Hubs.IExamHub FireAndForget()
            {
                throw new NotSupportedException();
            }

            public Task DisposeAsync()
            {
                throw new NotSupportedException();
            }

            public Task WaitForDisconnect()
            {
                throw new NotSupportedException();
            }

            public global::System.Threading.Tasks.Task JoinAsync(global::Exam01.Shared.MessagePackObjects.Player player)
            {
                return __parent.WriteMessageAsync<global::Exam01.Shared.MessagePackObjects.Player>(-733403293, player);
            }

            public global::System.Threading.Tasks.Task LeaveAsync()
            {
                return __parent.WriteMessageAsync<Nil>(1368362116, Nil.Default);
            }

            public global::System.Threading.Tasks.Task SendMessageAsync(string message)
            {
                return __parent.WriteMessageAsync<string>(-601690414, message);
            }

            public global::System.Threading.Tasks.Task MovePositionAsync(global::UnityEngine.Vector3 position)
            {
                return __parent.WriteMessageAsync<global::UnityEngine.Vector3>(1105294121, position);
            }

        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
