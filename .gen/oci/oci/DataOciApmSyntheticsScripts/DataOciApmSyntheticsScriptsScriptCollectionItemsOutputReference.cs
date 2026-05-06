using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmSyntheticsScripts
{
    [JsiiClass(nativeType: typeof(oci.DataOciApmSyntheticsScripts.DataOciApmSyntheticsScriptsScriptCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciApmSyntheticsScripts.DataOciApmSyntheticsScriptsScriptCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApmSyntheticsScriptsScriptCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApmSyntheticsScriptsScriptCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApmSyntheticsScriptsScriptCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmSyntheticsScriptsScriptCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApmDomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Content
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contentFileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentFileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contentSizeInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContentSizeInBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "monitorStatusCountMap", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsScripts.DataOciApmSyntheticsScriptsScriptCollectionItemsMonitorStatusCountMapList\"}")]
        public virtual oci.DataOciApmSyntheticsScripts.DataOciApmSyntheticsScriptsScriptCollectionItemsMonitorStatusCountMapList MonitorStatusCountMap
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsScripts.DataOciApmSyntheticsScriptsScriptCollectionItemsMonitorStatusCountMapList>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsScripts.DataOciApmSyntheticsScriptsScriptCollectionItemsParametersList\"}")]
        public virtual oci.DataOciApmSyntheticsScripts.DataOciApmSyntheticsScriptsScriptCollectionItemsParametersList Parameters
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsScripts.DataOciApmSyntheticsScriptsScriptCollectionItemsParametersList>()!;
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

        [JsiiProperty(name: "timeUploaded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUploaded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsScripts.DataOciApmSyntheticsScriptsScriptCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciApmSyntheticsScripts.IDataOciApmSyntheticsScriptsScriptCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsScripts.IDataOciApmSyntheticsScriptsScriptCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
