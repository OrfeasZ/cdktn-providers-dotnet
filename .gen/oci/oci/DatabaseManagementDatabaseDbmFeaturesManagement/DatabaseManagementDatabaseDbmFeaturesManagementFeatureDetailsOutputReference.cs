using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementDatabaseDbmFeaturesManagement
{
    [JsiiClass(nativeType: typeof(oci.DatabaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsOutputReference), fullyQualifiedName: "oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectorDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails\"}}]")]
        public virtual void PutConnectorDetails(oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabaseConnectionDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails\"}}]")]
        public virtual void PutDatabaseConnectionDetails(oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCanEnableAllCurrentPdbs")]
        public virtual void ResetCanEnableAllCurrentPdbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetIsAutoEnablePluggableDatabase")]
        public virtual void ResetIsAutoEnablePluggableDatabase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagementType")]
        public virtual void ResetManagementType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetailsOutputReference\"}")]
        public virtual oci.DatabaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetailsOutputReference ConnectorDetails
        {
            get => GetInstanceProperty<oci.DatabaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "databaseConnectionDetails", typeJson: "{\"fqn\":\"oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsOutputReference\"}")]
        public virtual oci.DatabaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsOutputReference DatabaseConnectionDetails
        {
            get => GetInstanceProperty<oci.DatabaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "canEnableAllCurrentPdbsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CanEnableAllCurrentPdbsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectorDetailsInput", typeJson: "{\"fqn\":\"oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails\"}", isOptional: true)]
        public virtual oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails? ConnectorDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsConnectorDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseConnectionDetailsInput", typeJson: "{\"fqn\":\"oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails\"}", isOptional: true)]
        public virtual oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails? DatabaseConnectionDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetailsDatabaseConnectionDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FeatureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isAutoEnablePluggableDatabaseInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsAutoEnablePluggableDatabaseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managementTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagementTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "canEnableAllCurrentPdbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object CanEnableAllCurrentPdbs
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Feature
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isAutoEnablePluggableDatabase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsAutoEnablePluggableDatabase
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "managementType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseManagementDatabaseDbmFeaturesManagement.DatabaseManagementDatabaseDbmFeaturesManagementFeatureDetails\"}", isOptional: true)]
        public virtual oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseManagementDatabaseDbmFeaturesManagement.IDatabaseManagementDatabaseDbmFeaturesManagementFeatureDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
