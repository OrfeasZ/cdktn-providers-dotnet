using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkInterface
{
    [JsiiClass(nativeType: typeof(aws.NetworkInterface.NetworkInterfaceEnaSrdSpecificationOutputReference), fullyQualifiedName: "aws.networkInterface.NetworkInterfaceEnaSrdSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkInterfaceEnaSrdSpecificationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkInterfaceEnaSrdSpecificationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkInterfaceEnaSrdSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkInterfaceEnaSrdSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEnaSrdUdpSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification\"}}]")]
        public virtual void PutEnaSrdUdpSpecification(aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnaSrdEnabled")]
        public virtual void ResetEnaSrdEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnaSrdUdpSpecification")]
        public virtual void ResetEnaSrdUdpSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "enaSrdUdpSpecification", typeJson: "{\"fqn\":\"aws.networkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference\"}")]
        public virtual aws.NetworkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference EnaSrdUdpSpecification
        {
            get => GetInstanceProperty<aws.NetworkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enaSrdEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnaSrdEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enaSrdUdpSpecificationInput", typeJson: "{\"fqn\":\"aws.networkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification\"}", isOptional: true)]
        public virtual aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification? EnaSrdUdpSpecificationInput
        {
            get => GetInstanceProperty<aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification?>();
        }

        [JsiiProperty(name: "enaSrdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnaSrdEnabled
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkInterface.NetworkInterfaceEnaSrdSpecification\"}", isOptional: true)]
        public virtual aws.NetworkInterface.INetworkInterfaceEnaSrdSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.NetworkInterface.INetworkInterfaceEnaSrdSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
