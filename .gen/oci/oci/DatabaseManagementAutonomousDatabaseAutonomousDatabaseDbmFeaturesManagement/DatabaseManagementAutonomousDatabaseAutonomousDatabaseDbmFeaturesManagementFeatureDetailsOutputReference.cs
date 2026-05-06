using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement
{
    [JsiiClass(nativeType: typeof(oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsOutputReference), fullyQualifiedName: "oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectorDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails\"}}]")]
        public virtual void PutConnectorDetails(oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabaseConnectionDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails\"}}]")]
        public virtual void PutDatabaseConnectionDetails(oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectorDetails")]
        public virtual void ResetConnectorDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseConnectionDetails")]
        public virtual void ResetDatabaseConnectionDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetailsOutputReference\"}")]
        public virtual oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetailsOutputReference ConnectorDetails
        {
            get => GetInstanceProperty<oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "databaseConnectionDetails", typeJson: "{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsOutputReference\"}")]
        public virtual oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsOutputReference DatabaseConnectionDetails
        {
            get => GetInstanceProperty<oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectorDetailsInput", typeJson: "{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails\"}", isOptional: true)]
        public virtual oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails? ConnectorDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseConnectionDetailsInput", typeJson: "{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails\"}", isOptional: true)]
        public virtual oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails? DatabaseConnectionDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetails\"}", isOptional: true)]
        public virtual oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagement.IDatabaseManagementAutonomousDatabaseAutonomousDatabaseDbmFeaturesManagementFeatureDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
