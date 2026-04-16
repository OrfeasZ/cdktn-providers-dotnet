using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayInstanceServers
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayInstanceServers.DataScalewayInstanceServersServersOutputReference), fullyQualifiedName: "scaleway.dataScalewayInstanceServers.DataScalewayInstanceServersServersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayInstanceServersServersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayInstanceServersServersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayInstanceServersServersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayInstanceServersServersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bootscriptId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootscriptId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableDynamicIp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableDynamicIp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementGroupPolicyRespected", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PlacementGroupPolicyRespected
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "privateIps", typeJson: "{\"fqn\":\"scaleway.dataScalewayInstanceServers.DataScalewayInstanceServersServersPrivateIpsList\"}")]
        public virtual scaleway.DataScalewayInstanceServers.DataScalewayInstanceServersServersPrivateIpsList PrivateIps
        {
            get => GetInstanceProperty<scaleway.DataScalewayInstanceServers.DataScalewayInstanceServersServersPrivateIpsList>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIps", typeJson: "{\"fqn\":\"scaleway.dataScalewayInstanceServers.DataScalewayInstanceServersServersPublicIpsList\"}")]
        public virtual scaleway.DataScalewayInstanceServers.DataScalewayInstanceServersServersPublicIpsList PublicIps
        {
            get => GetInstanceProperty<scaleway.DataScalewayInstanceServers.DataScalewayInstanceServersServersPublicIpsList>()!;
        }

        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayInstanceServers.DataScalewayInstanceServersServers\"}", isOptional: true)]
        public virtual scaleway.DataScalewayInstanceServers.IDataScalewayInstanceServersServers? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayInstanceServers.IDataScalewayInstanceServersServers?>();
            set => SetInstanceProperty(value);
        }
    }
}
