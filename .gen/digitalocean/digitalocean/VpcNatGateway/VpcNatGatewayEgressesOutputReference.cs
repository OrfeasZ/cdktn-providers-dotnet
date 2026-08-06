using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.VpcNatGateway
{
    [JsiiClass(nativeType: typeof(digitalocean.VpcNatGateway.VpcNatGatewayEgressesOutputReference), fullyQualifiedName: "digitalocean.vpcNatGateway.VpcNatGatewayEgressesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpcNatGatewayEgressesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpcNatGatewayEgressesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpcNatGatewayEgressesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcNatGatewayEgressesOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways" />)[]</param>
        [JsiiMethod(name: "putPublicGateways", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.vpcNatGateway.VpcNatGatewayEgressesPublicGateways\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPublicGateways(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPublicGateways")]
        public virtual void ResetPublicGateways()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "publicGateways", typeJson: "{\"fqn\":\"digitalocean.vpcNatGateway.VpcNatGatewayEgressesPublicGatewaysList\"}")]
        public virtual digitalocean.VpcNatGateway.VpcNatGatewayEgressesPublicGatewaysList PublicGateways
        {
            get => GetInstanceProperty<digitalocean.VpcNatGateway.VpcNatGatewayEgressesPublicGatewaysList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.VpcNatGateway.IVpcNatGatewayEgressesPublicGateways" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicGatewaysInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.vpcNatGateway.VpcNatGatewayEgressesPublicGateways\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PublicGatewaysInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.vpcNatGateway.VpcNatGatewayEgresses\"}", isOptional: true)]
        public virtual digitalocean.VpcNatGateway.IVpcNatGatewayEgresses? InternalValue
        {
            get => GetInstanceProperty<digitalocean.VpcNatGateway.IVpcNatGatewayEgresses?>();
            set => SetInstanceProperty(value);
        }
    }
}
