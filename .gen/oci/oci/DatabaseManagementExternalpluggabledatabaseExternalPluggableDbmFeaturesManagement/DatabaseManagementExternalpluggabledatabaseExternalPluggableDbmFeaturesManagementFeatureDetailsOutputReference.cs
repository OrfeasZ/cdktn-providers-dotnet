using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement
{
    [JsiiClass(nativeType: typeof(oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsOutputReference), fullyQualifiedName: "oci.databaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectorDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails\"}}]")]
        public virtual void PutConnectorDetails(oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectorDetails")]
        public virtual void ResetConnectorDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetailsOutputReference\"}")]
        public virtual oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetailsOutputReference ConnectorDetails
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectorDetailsInput", typeJson: "{\"fqn\":\"oci.databaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails\"}", isOptional: true)]
        public virtual oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails? ConnectorDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FeatureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Feature
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetails\"}", isOptional: true)]
        public virtual oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
