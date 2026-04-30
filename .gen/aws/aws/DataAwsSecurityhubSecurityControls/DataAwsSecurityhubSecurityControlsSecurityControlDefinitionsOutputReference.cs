using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSecurityhubSecurityControls
{
    [JsiiClass(nativeType: typeof(aws.DataAwsSecurityhubSecurityControls.DataAwsSecurityhubSecurityControlsSecurityControlDefinitionsOutputReference), fullyQualifiedName: "aws.dataAwsSecurityhubSecurityControls.DataAwsSecurityhubSecurityControlsSecurityControlDefinitionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsSecurityhubSecurityControlsSecurityControlDefinitionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsSecurityhubSecurityControlsSecurityControlDefinitionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsSecurityhubSecurityControlsSecurityControlDefinitionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSecurityhubSecurityControlsSecurityControlDefinitionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "currentRegionAvailability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentRegionAvailability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customizableProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CustomizableProperties
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remediationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemediationUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityControlId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityControlId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "severityRating", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SeverityRating
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsSecurityhubSecurityControls.DataAwsSecurityhubSecurityControlsSecurityControlDefinitions\"}", isOptional: true)]
        public virtual aws.DataAwsSecurityhubSecurityControls.IDataAwsSecurityhubSecurityControlsSecurityControlDefinitions? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsSecurityhubSecurityControls.IDataAwsSecurityhubSecurityControlsSecurityControlDefinitions?>();
            set => SetInstanceProperty(value);
        }
    }
}
