using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlJobStep
{
    [JsiiClass(nativeType: typeof(azurerm.MssqlJobStep.MssqlJobStepOutputTargetOutputReference), fullyQualifiedName: "azurerm.mssqlJobStep.MssqlJobStepOutputTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MssqlJobStepOutputTargetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MssqlJobStepOutputTargetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MssqlJobStepOutputTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MssqlJobStepOutputTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetJobCredentialId")]
        public virtual void ResetJobCredentialId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaName")]
        public virtual void ResetSchemaName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobCredentialIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobCredentialIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mssqlDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MssqlDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemaNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "jobCredentialId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobCredentialId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mssqlDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MssqlDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.mssqlJobStep.MssqlJobStepOutputTarget\"}", isOptional: true)]
        public virtual azurerm.MssqlJobStep.IMssqlJobStepOutputTarget? InternalValue
        {
            get => GetInstanceProperty<azurerm.MssqlJobStep.IMssqlJobStepOutputTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
