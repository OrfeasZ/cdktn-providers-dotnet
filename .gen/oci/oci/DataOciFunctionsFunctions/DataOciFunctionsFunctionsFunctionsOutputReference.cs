using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFunctionsFunctions
{
    [JsiiClass(nativeType: typeof(oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsOutputReference), fullyQualifiedName: "oci.dataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFunctionsFunctionsFunctionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFunctionsFunctionsFunctionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFunctionsFunctionsFunctionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFunctionsFunctionsFunctionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Config
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "detachedModeTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DetachedModeTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failureDestination", typeJson: "{\"fqn\":\"oci.dataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsFailureDestinationList\"}")]
        public virtual oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsFailureDestinationList FailureDestination
        {
            get => GetInstanceProperty<oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsFailureDestinationList>()!;
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

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageDigest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invokeEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvokeEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memoryInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemoryInMbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisionedConcurrencyConfig", typeJson: "{\"fqn\":\"oci.dataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsProvisionedConcurrencyConfigList\"}")]
        public virtual oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsProvisionedConcurrencyConfigList ProvisionedConcurrencyConfig
        {
            get => GetInstanceProperty<oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsProvisionedConcurrencyConfigList>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.dataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetailsList\"}")]
        public virtual oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetailsList SourceDetails
        {
            get => GetInstanceProperty<oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSourceDetailsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "successDestination", typeJson: "{\"fqn\":\"oci.dataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSuccessDestinationList\"}")]
        public virtual oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSuccessDestinationList SuccessDestination
        {
            get => GetInstanceProperty<oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsSuccessDestinationList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "traceConfig", typeJson: "{\"fqn\":\"oci.dataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsTraceConfigList\"}")]
        public virtual oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsTraceConfigList TraceConfig
        {
            get => GetInstanceProperty<oci.DataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctionsTraceConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFunctionsFunctions.DataOciFunctionsFunctionsFunctions\"}", isOptional: true)]
        public virtual oci.DataOciFunctionsFunctions.IDataOciFunctionsFunctionsFunctions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFunctionsFunctions.IDataOciFunctionsFunctionsFunctions?>();
            set => SetInstanceProperty(value);
        }
    }
}
