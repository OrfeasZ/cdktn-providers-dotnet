using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeServiceNetworkVpcAssociation
{
    [JsiiClass(nativeType: typeof(aws.VpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationDnsOptionsOutputReference), fullyQualifiedName: "aws.vpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationDnsOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpclatticeServiceNetworkVpcAssociationDnsOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpclatticeServiceNetworkVpcAssociationDnsOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpclatticeServiceNetworkVpcAssociationDnsOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpclatticeServiceNetworkVpcAssociationDnsOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPrivateDnsPreference")]
        public virtual void ResetPrivateDnsPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateDnsSpecifiedDomains")]
        public virtual void ResetPrivateDnsSpecifiedDomains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateDnsPreferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateDnsPreferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateDnsSpecifiedDomainsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PrivateDnsSpecifiedDomainsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "privateDnsPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDnsPreference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateDnsSpecifiedDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PrivateDnsSpecifiedDomains
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.vpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationDnsOptions\"}", isOptional: true)]
        public virtual aws.VpclatticeServiceNetworkVpcAssociation.IVpclatticeServiceNetworkVpcAssociationDnsOptions? InternalValue
        {
            get => GetInstanceProperty<aws.VpclatticeServiceNetworkVpcAssociation.IVpclatticeServiceNetworkVpcAssociationDnsOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
