using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsCloudGate
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsCloudGate.DataOciIdentityDomainsCloudGateMappingsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsCloudGate.DataOciIdentityDomainsCloudGateMappingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsCloudGateMappingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsCloudGateMappingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsCloudGateMappingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsCloudGateMappingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mappingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MappingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nginxSettings", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NginxSettings
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyPass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyPass
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ref", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ref
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourcePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourcePrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upstreamServerGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpstreamServerGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGate.DataOciIdentityDomainsCloudGateMappings\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsCloudGate.IDataOciIdentityDomainsCloudGateMappings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGate.IDataOciIdentityDomainsCloudGateMappings?>();
            set => SetInstanceProperty(value);
        }
    }
}
