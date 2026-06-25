using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationAssessment
{
    [JsiiClass(nativeType: typeof(oci.DatabaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnectionOutputReference), fullyQualifiedName: "oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseMigrationAssessmentTargetDatabaseConnectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseMigrationAssessmentTargetDatabaseConnectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseMigrationAssessmentTargetDatabaseConnectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationAssessmentTargetDatabaseConnectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConnectionType")]
        public virtual void ResetConnectionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseVersion")]
        public virtual void ResetDatabaseVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTechnologySubType")]
        public virtual void ResetTechnologySubType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTechnologyType")]
        public virtual void ResetTechnologyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "technologySubTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TechnologySubTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "technologyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TechnologyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "technologySubType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TechnologySubType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "technologyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TechnologyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnection\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTargetDatabaseConnection? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTargetDatabaseConnection?>();
            set => SetInstanceProperty(value);
        }
    }
}
