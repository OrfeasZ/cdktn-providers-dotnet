using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotFlowRuntime
{
    [JsiiClass(nativeType: typeof(oci.IotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigOutputReference), fullyQualifiedName: "oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotIotFlowRuntimeNetworkConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotIotFlowRuntimeNetworkConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIotFlowRuntimeNetworkConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIotFlowRuntimeNetworkConfigOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfigFileStorageMounts" />)[]</param>
        [JsiiMethod(name: "putFileStorageMounts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigFileStorageMounts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFileStorageMounts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfigFileStorageMounts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfigFileStorageMounts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfigFileStorageMounts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFileStorageMounts")]
        public virtual void ResetFileStorageMounts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkSecurityGroupIds")]
        public virtual void ResetNetworkSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fileStorageMounts", typeJson: "{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigFileStorageMountsList\"}")]
        public virtual oci.IotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigFileStorageMountsList FileStorageMounts
        {
            get => GetInstanceProperty<oci.IotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigFileStorageMountsList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfigFileStorageMounts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileStorageMountsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigFileStorageMounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FileStorageMountsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkSecurityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NetworkSecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfig\"}", isOptional: true)]
        public virtual oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfig? InternalValue
        {
            get => GetInstanceProperty<oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
