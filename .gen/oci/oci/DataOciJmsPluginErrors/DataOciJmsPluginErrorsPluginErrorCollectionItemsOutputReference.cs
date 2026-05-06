using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsPluginErrors
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsPluginErrors.DataOciJmsPluginErrorsPluginErrorCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsPluginErrors.DataOciJmsPluginErrorsPluginErrorCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsPluginErrorsPluginErrorCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsPluginErrorsPluginErrorCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsPluginErrorsPluginErrorCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsPluginErrorsPluginErrorCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errors", typeJson: "{\"fqn\":\"oci.dataOciJmsPluginErrors.DataOciJmsPluginErrorsPluginErrorCollectionItemsErrorsList\"}")]
        public virtual oci.DataOciJmsPluginErrors.DataOciJmsPluginErrorsPluginErrorCollectionItemsErrorsList Errors
        {
            get => GetInstanceProperty<oci.DataOciJmsPluginErrors.DataOciJmsPluginErrorsPluginErrorCollectionItemsErrorsList>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFirstSeen", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFirstSeen
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastSeen", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastSeen
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsPluginErrors.DataOciJmsPluginErrorsPluginErrorCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsPluginErrors.IDataOciJmsPluginErrorsPluginErrorCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsPluginErrors.IDataOciJmsPluginErrorsPluginErrorCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
