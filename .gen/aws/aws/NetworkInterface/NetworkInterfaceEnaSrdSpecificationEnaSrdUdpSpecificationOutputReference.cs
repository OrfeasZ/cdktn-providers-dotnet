using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkInterface
{
    [JsiiClass(nativeType: typeof(aws.NetworkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference), fullyQualifiedName: "aws.networkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEnaSrdUdpEnabled")]
        public virtual void ResetEnaSrdUdpEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "enaSrdUdpEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnaSrdUdpEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "enaSrdUdpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnaSrdUdpEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification\"}", isOptional: true)]
        public virtual aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
