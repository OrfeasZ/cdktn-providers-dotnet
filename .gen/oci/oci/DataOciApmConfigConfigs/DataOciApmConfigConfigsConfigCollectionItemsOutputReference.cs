using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmConfigConfigs
{
    [JsiiClass(nativeType: typeof(oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApmConfigConfigsConfigCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApmConfigConfigsConfigCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApmConfigConfigsConfigCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmConfigConfigsConfigCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApmDomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attachInstallDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttachInstallDir
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"oci.dataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsConfigList\"}")]
        public virtual oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsConfigList Config
        {
            get => GetInstanceProperty<oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsConfigList>()!;
        }

        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"oci.dataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsDimensionsList\"}")]
        public virtual oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsDimensionsList Dimensions
        {
            get => GetInstanceProperty<oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsDimensionsList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FilterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filterText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FilterText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Group
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inUseBy", typeJson: "{\"fqn\":\"oci.dataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsInUseByList\"}")]
        public virtual oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsInUseByList InUseBy
        {
            get => GetInstanceProperty<oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsInUseByList>()!;
        }

        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "matchAgentsWithAttributeKey", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MatchAgentsWithAttributeKey
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "matchAgentsWithAttributeValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MatchAgentsWithAttributeValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"oci.dataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsMetricsList\"}")]
        public virtual oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsMetricsList Metrics
        {
            get => GetInstanceProperty<oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsMetricsList>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opcDryRun", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcDryRun
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "options", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Options
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overrides", typeJson: "{\"fqn\":\"oci.dataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsOverridesList\"}")]
        public virtual oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsOverridesList Overrides
        {
            get => GetInstanceProperty<oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsOverridesList>()!;
        }

        [JsiiProperty(name: "processFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ProcessFilter
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "rules", typeJson: "{\"fqn\":\"oci.dataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsRulesList\"}")]
        public virtual oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsRulesList Rules
        {
            get => GetInstanceProperty<oci.DataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItemsRulesList>()!;
        }

        [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunAsUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApmConfigConfigs.DataOciApmConfigConfigsConfigCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciApmConfigConfigs.IDataOciApmConfigConfigsConfigCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApmConfigConfigs.IDataOciApmConfigConfigsConfigCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
