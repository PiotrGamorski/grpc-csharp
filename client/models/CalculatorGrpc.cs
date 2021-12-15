// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: calculator.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Calculator {
  public static partial class CalculatorService
  {
    static readonly string __ServiceName = "calculator.CalculatorService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.CalculatorRequest> __Marshaller_calculator_CalculatorRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.CalculatorRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.CalculatorResponse> __Marshaller_calculator_CalculatorResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.CalculatorResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.PrimeNumRequest> __Marshaller_calculator_PrimeNumRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.PrimeNumRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.PrimeNumResponse> __Marshaller_calculator_PrimeNumResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.PrimeNumResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.ComputeDivisorsRequest> __Marshaller_calculator_ComputeDivisorsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.ComputeDivisorsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.ComputeDivisorsResponse> __Marshaller_calculator_ComputeDivisorsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.ComputeDivisorsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.ComputeAverageRequest> __Marshaller_calculator_ComputeAverageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.ComputeAverageRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.ComputeAverageResponse> __Marshaller_calculator_ComputeAverageResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.ComputeAverageResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.ComputeMinMaxRequest> __Marshaller_calculator_ComputeMinMaxRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.ComputeMinMaxRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.ComputeMinMaxResponse> __Marshaller_calculator_ComputeMinMaxResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.ComputeMinMaxResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.ComputeCurrentMaxRequest> __Marshaller_calculator_ComputeCurrentMaxRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.ComputeCurrentMaxRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Calculator.ComputeCurrentMaxResponse> __Marshaller_calculator_ComputeCurrentMaxResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Calculator.ComputeCurrentMaxResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculator.CalculatorRequest, global::Calculator.CalculatorResponse> __Method_Sum = new grpc::Method<global::Calculator.CalculatorRequest, global::Calculator.CalculatorResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Sum",
        __Marshaller_calculator_CalculatorRequest,
        __Marshaller_calculator_CalculatorResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculator.PrimeNumRequest, global::Calculator.PrimeNumResponse> __Method_PrimeNumberDecomposition = new grpc::Method<global::Calculator.PrimeNumRequest, global::Calculator.PrimeNumResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "PrimeNumberDecomposition",
        __Marshaller_calculator_PrimeNumRequest,
        __Marshaller_calculator_PrimeNumResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculator.ComputeDivisorsRequest, global::Calculator.ComputeDivisorsResponse> __Method_ComputeAllDivisors = new grpc::Method<global::Calculator.ComputeDivisorsRequest, global::Calculator.ComputeDivisorsResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ComputeAllDivisors",
        __Marshaller_calculator_ComputeDivisorsRequest,
        __Marshaller_calculator_ComputeDivisorsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculator.ComputeAverageRequest, global::Calculator.ComputeAverageResponse> __Method_ComputeAverage = new grpc::Method<global::Calculator.ComputeAverageRequest, global::Calculator.ComputeAverageResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "ComputeAverage",
        __Marshaller_calculator_ComputeAverageRequest,
        __Marshaller_calculator_ComputeAverageResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculator.ComputeMinMaxRequest, global::Calculator.ComputeMinMaxResponse> __Method_ComputeMinMax = new grpc::Method<global::Calculator.ComputeMinMaxRequest, global::Calculator.ComputeMinMaxResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "ComputeMinMax",
        __Marshaller_calculator_ComputeMinMaxRequest,
        __Marshaller_calculator_ComputeMinMaxResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Calculator.ComputeCurrentMaxRequest, global::Calculator.ComputeCurrentMaxResponse> __Method_ComputeCurrentMax = new grpc::Method<global::Calculator.ComputeCurrentMaxRequest, global::Calculator.ComputeCurrentMaxResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "ComputeCurrentMax",
        __Marshaller_calculator_ComputeCurrentMaxRequest,
        __Marshaller_calculator_ComputeCurrentMaxResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Calculator.CalculatorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CalculatorService</summary>
    [grpc::BindServiceMethod(typeof(CalculatorService), "BindService")]
    public abstract partial class CalculatorServiceBase
    {
      /// <summary>
      /// Unary
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculator.CalculatorResponse> Sum(global::Calculator.CalculatorRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Server Streaming
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task PrimeNumberDecomposition(global::Calculator.PrimeNumRequest request, grpc::IServerStreamWriter<global::Calculator.PrimeNumResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Server Streaming
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ComputeAllDivisors(global::Calculator.ComputeDivisorsRequest request, grpc::IServerStreamWriter<global::Calculator.ComputeDivisorsResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Client Streaming
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculator.ComputeAverageResponse> ComputeAverage(grpc::IAsyncStreamReader<global::Calculator.ComputeAverageRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Client Streaming
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Calculator.ComputeMinMaxResponse> ComputeMinMax(grpc::IAsyncStreamReader<global::Calculator.ComputeMinMaxRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Bi-Directional Streaming
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ComputeCurrentMax(grpc::IAsyncStreamReader<global::Calculator.ComputeCurrentMaxRequest> requestStream, grpc::IServerStreamWriter<global::Calculator.ComputeCurrentMaxResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CalculatorService</summary>
    public partial class CalculatorServiceClient : grpc::ClientBase<CalculatorServiceClient>
    {
      /// <summary>Creates a new client for CalculatorService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CalculatorServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CalculatorService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CalculatorServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CalculatorServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CalculatorServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Unary
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculator.CalculatorResponse Sum(global::Calculator.CalculatorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Sum(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Unary
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Calculator.CalculatorResponse Sum(global::Calculator.CalculatorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Sum, null, options, request);
      }
      /// <summary>
      /// Unary
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculator.CalculatorResponse> SumAsync(global::Calculator.CalculatorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SumAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Unary
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Calculator.CalculatorResponse> SumAsync(global::Calculator.CalculatorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Sum, null, options, request);
      }
      /// <summary>
      /// Server Streaming
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Calculator.PrimeNumResponse> PrimeNumberDecomposition(global::Calculator.PrimeNumRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PrimeNumberDecomposition(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Server Streaming
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Calculator.PrimeNumResponse> PrimeNumberDecomposition(global::Calculator.PrimeNumRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_PrimeNumberDecomposition, null, options, request);
      }
      /// <summary>
      /// Server Streaming
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Calculator.ComputeDivisorsResponse> ComputeAllDivisors(global::Calculator.ComputeDivisorsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ComputeAllDivisors(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Server Streaming
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Calculator.ComputeDivisorsResponse> ComputeAllDivisors(global::Calculator.ComputeDivisorsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ComputeAllDivisors, null, options, request);
      }
      /// <summary>
      /// Client Streaming
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Calculator.ComputeAverageRequest, global::Calculator.ComputeAverageResponse> ComputeAverage(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ComputeAverage(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Client Streaming
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Calculator.ComputeAverageRequest, global::Calculator.ComputeAverageResponse> ComputeAverage(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_ComputeAverage, null, options);
      }
      /// <summary>
      /// Client Streaming
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Calculator.ComputeMinMaxRequest, global::Calculator.ComputeMinMaxResponse> ComputeMinMax(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ComputeMinMax(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Client Streaming
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Calculator.ComputeMinMaxRequest, global::Calculator.ComputeMinMaxResponse> ComputeMinMax(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_ComputeMinMax, null, options);
      }
      /// <summary>
      /// Bi-Directional Streaming
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Calculator.ComputeCurrentMaxRequest, global::Calculator.ComputeCurrentMaxResponse> ComputeCurrentMax(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ComputeCurrentMax(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Bi-Directional Streaming
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Calculator.ComputeCurrentMaxRequest, global::Calculator.ComputeCurrentMaxResponse> ComputeCurrentMax(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_ComputeCurrentMax, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CalculatorServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CalculatorServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CalculatorServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Sum, serviceImpl.Sum)
          .AddMethod(__Method_PrimeNumberDecomposition, serviceImpl.PrimeNumberDecomposition)
          .AddMethod(__Method_ComputeAllDivisors, serviceImpl.ComputeAllDivisors)
          .AddMethod(__Method_ComputeAverage, serviceImpl.ComputeAverage)
          .AddMethod(__Method_ComputeMinMax, serviceImpl.ComputeMinMax)
          .AddMethod(__Method_ComputeCurrentMax, serviceImpl.ComputeCurrentMax).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CalculatorServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Sum, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Calculator.CalculatorRequest, global::Calculator.CalculatorResponse>(serviceImpl.Sum));
      serviceBinder.AddMethod(__Method_PrimeNumberDecomposition, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Calculator.PrimeNumRequest, global::Calculator.PrimeNumResponse>(serviceImpl.PrimeNumberDecomposition));
      serviceBinder.AddMethod(__Method_ComputeAllDivisors, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Calculator.ComputeDivisorsRequest, global::Calculator.ComputeDivisorsResponse>(serviceImpl.ComputeAllDivisors));
      serviceBinder.AddMethod(__Method_ComputeAverage, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Calculator.ComputeAverageRequest, global::Calculator.ComputeAverageResponse>(serviceImpl.ComputeAverage));
      serviceBinder.AddMethod(__Method_ComputeMinMax, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Calculator.ComputeMinMaxRequest, global::Calculator.ComputeMinMaxResponse>(serviceImpl.ComputeMinMax));
      serviceBinder.AddMethod(__Method_ComputeCurrentMax, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Calculator.ComputeCurrentMaxRequest, global::Calculator.ComputeCurrentMaxResponse>(serviceImpl.ComputeCurrentMax));
    }

  }
}
#endregion
