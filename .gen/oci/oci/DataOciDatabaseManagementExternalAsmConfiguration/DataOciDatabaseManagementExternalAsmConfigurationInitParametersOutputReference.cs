using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementExternalAsmConfiguration
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementExternalAsmConfiguration.DataOciDatabaseManagementExternalAsmConfigurationInitParametersOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementExternalAsmConfiguration.DataOciDatabaseManagementExternalAsmConfigurationInitParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementExternalAsmConfigurationInitParametersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementExternalAsmConfigurationInitParametersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementExternalAsmConfigurationInitParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExternalAsmConfigurationInitParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "asmInstanceDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AsmInstanceDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "asmInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AsmInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoMountDiskGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AutoMountDiskGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "diskDiscoveryPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskDiscoveryPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preferredReadFailureGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PreferredReadFailureGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "rebalancePower", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RebalancePower
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalAsmConfiguration.DataOciDatabaseManagementExternalAsmConfigurationInitParameters\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementExternalAsmConfiguration.IDataOciDatabaseManagementExternalAsmConfigurationInitParameters? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalAsmConfiguration.IDataOciDatabaseManagementExternalAsmConfigurationInitParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
