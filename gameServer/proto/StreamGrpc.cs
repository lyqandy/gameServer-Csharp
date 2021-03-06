// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: stream.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Stream {
  /// <summary>
  /// CSStream definition
  /// </summary>
  public static partial class CSStream
  {
    static readonly string __ServiceName = "stream.CSStream";

    static readonly grpc::Marshaller<global::Stream.Package.Types.Frame> __Marshaller_Frame = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Stream.Package.Types.Frame.Parser.ParseFrom);

    static readonly grpc::Method<global::Stream.Package.Types.Frame, global::Stream.Package.Types.Frame> __Method_Stream = new grpc::Method<global::Stream.Package.Types.Frame, global::Stream.Package.Types.Frame>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "Stream",
        __Marshaller_Frame,
        __Marshaller_Frame);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Stream.StreamReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CSStream</summary>
    public abstract partial class CSStreamBase
    {
      public virtual global::System.Threading.Tasks.Task Stream(grpc::IAsyncStreamReader<global::Stream.Package.Types.Frame> requestStream, grpc::IServerStreamWriter<global::Stream.Package.Types.Frame> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CSStream</summary>
    public partial class CSStreamClient : grpc::ClientBase<CSStreamClient>
    {
      /// <summary>Creates a new client for CSStream</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CSStreamClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CSStream that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CSStreamClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CSStreamClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CSStreamClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::Stream.Package.Types.Frame, global::Stream.Package.Types.Frame> Stream(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Stream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Stream.Package.Types.Frame, global::Stream.Package.Types.Frame> Stream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_Stream, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CSStreamClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CSStreamClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CSStreamBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Stream, serviceImpl.Stream).Build();
    }

  }
  /// <summary>
  //// SimpleService definition
  /// </summary>
  public static partial class SimpleService
  {
    static readonly string __ServiceName = "stream.SimpleService";

    static readonly grpc::Marshaller<global::Stream.Package.Types.Frame> __Marshaller_Frame = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Stream.Package.Types.Frame.Parser.ParseFrom);

    static readonly grpc::Method<global::Stream.Package.Types.Frame, global::Stream.Package.Types.Frame> __Method_SimpleRequest = new grpc::Method<global::Stream.Package.Types.Frame, global::Stream.Package.Types.Frame>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SimpleRequest",
        __Marshaller_Frame,
        __Marshaller_Frame);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Stream.StreamReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of SimpleService</summary>
    public abstract partial class SimpleServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Stream.Package.Types.Frame> SimpleRequest(global::Stream.Package.Types.Frame request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SimpleService</summary>
    public partial class SimpleServiceClient : grpc::ClientBase<SimpleServiceClient>
    {
      /// <summary>Creates a new client for SimpleService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SimpleServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SimpleService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SimpleServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SimpleServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SimpleServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Stream.Package.Types.Frame SimpleRequest(global::Stream.Package.Types.Frame request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SimpleRequest(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Stream.Package.Types.Frame SimpleRequest(global::Stream.Package.Types.Frame request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SimpleRequest, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Stream.Package.Types.Frame> SimpleRequestAsync(global::Stream.Package.Types.Frame request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SimpleRequestAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Stream.Package.Types.Frame> SimpleRequestAsync(global::Stream.Package.Types.Frame request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SimpleRequest, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SimpleServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SimpleServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SimpleServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SimpleRequest, serviceImpl.SimpleRequest).Build();
    }

  }
}
#endregion
