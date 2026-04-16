using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DatawarehouseDeployment
{
    [JsiiClass(nativeType: typeof(scaleway.DatawarehouseDeployment.DatawarehouseDeploymentPrivateNetworkOutputReference), fullyQualifiedName: "scaleway.datawarehouseDeployment.DatawarehouseDeploymentPrivateNetworkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatawarehouseDeploymentPrivateNetworkOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatawarehouseDeploymentPrivateNetworkOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatawarehouseDeploymentPrivateNetworkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatawarehouseDeploymentPrivateNetworkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dnsRecord", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsRecord
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "services", typeJson: "{\"fqn\":\"scaleway.datawarehouseDeployment.DatawarehouseDeploymentPrivateNetworkServicesList\"}")]
        public virtual scaleway.DatawarehouseDeployment.DatawarehouseDeploymentPrivateNetworkServicesList Services
        {
            get => GetInstanceProperty<scaleway.DatawarehouseDeployment.DatawarehouseDeploymentPrivateNetworkServicesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pnIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PnIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PnId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.datawarehouseDeployment.DatawarehouseDeploymentPrivateNetwork\"}", isOptional: true)]
        public virtual scaleway.DatawarehouseDeployment.IDatawarehouseDeploymentPrivateNetwork? InternalValue
        {
            get => GetInstanceProperty<scaleway.DatawarehouseDeployment.IDatawarehouseDeploymentPrivateNetwork?>();
            set => SetInstanceProperty(value);
        }
    }
}
