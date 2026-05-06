using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsAgentInstallers
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsAgentInstallers.DataOciJmsAgentInstallersAgentInstallerCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsAgentInstallers.DataOciJmsAgentInstallersAgentInstallerCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsAgentInstallersAgentInstallerCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsAgentInstallersAgentInstallerCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsAgentInstallersAgentInstallerCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsAgentInstallersAgentInstallerCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentInstallerDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentInstallerDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "agentInstallerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentInstallerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "agentInstallerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentInstallerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "approximateFileSizeInBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApproximateFileSizeInBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformArchitecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformArchitecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sha256", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sha256
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsAgentInstallers.DataOciJmsAgentInstallersAgentInstallerCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsAgentInstallers.IDataOciJmsAgentInstallersAgentInstallerCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsAgentInstallers.IDataOciJmsAgentInstallersAgentInstallerCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
