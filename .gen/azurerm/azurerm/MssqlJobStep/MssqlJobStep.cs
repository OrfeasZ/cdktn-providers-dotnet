using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlJobStep
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/mssql_job_step azurerm_mssql_job_step}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MssqlJobStep.MssqlJobStep), fullyQualifiedName: "azurerm.mssqlJobStep.MssqlJobStep", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.mssqlJobStep.MssqlJobStepConfig\"}}]")]
    public class MssqlJobStep : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/mssql_job_step azurerm_mssql_job_step} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MssqlJobStep(Constructs.Construct scope, string id, azurerm.MssqlJobStep.IMssqlJobStepConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MssqlJobStep.IMssqlJobStepConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MssqlJobStep(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MssqlJobStep(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a MssqlJobStep resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MssqlJobStep to import.</param>
        /// <param name="importFromId">The id of the existing MssqlJobStep that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MssqlJobStep to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MssqlJobStep to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/mssql_job_step#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MssqlJobStep that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MssqlJobStep to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.MssqlJobStep.MssqlJobStep), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putOutputTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mssqlJobStep.MssqlJobStepOutputTarget\"}}]")]
        public virtual void PutOutputTarget(azurerm.MssqlJobStep.IMssqlJobStepOutputTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MssqlJobStep.IMssqlJobStepOutputTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mssqlJobStep.MssqlJobStepTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MssqlJobStep.IMssqlJobStepTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MssqlJobStep.IMssqlJobStepTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialRetryIntervalSeconds")]
        public virtual void ResetInitialRetryIntervalSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobCredentialId")]
        public virtual void ResetJobCredentialId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumRetryIntervalSeconds")]
        public virtual void ResetMaximumRetryIntervalSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputTarget")]
        public virtual void ResetOutputTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryAttempts")]
        public virtual void ResetRetryAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryIntervalBackoffMultiplier")]
        public virtual void ResetRetryIntervalBackoffMultiplier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutSeconds")]
        public virtual void ResetTimeoutSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.MssqlJobStep.MssqlJobStep))!;

        [JsiiProperty(name: "outputTarget", typeJson: "{\"fqn\":\"azurerm.mssqlJobStep.MssqlJobStepOutputTargetOutputReference\"}")]
        public virtual azurerm.MssqlJobStep.MssqlJobStepOutputTargetOutputReference OutputTarget
        {
            get => GetInstanceProperty<azurerm.MssqlJobStep.MssqlJobStepOutputTargetOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mssqlJobStep.MssqlJobStepTimeoutsOutputReference\"}")]
        public virtual azurerm.MssqlJobStep.MssqlJobStepTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MssqlJobStep.MssqlJobStepTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialRetryIntervalSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InitialRetryIntervalSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobCredentialIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobCredentialIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobStepIndexInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? JobStepIndexInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobTargetGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobTargetGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRetryIntervalSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumRetryIntervalSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputTargetInput", typeJson: "{\"fqn\":\"azurerm.mssqlJobStep.MssqlJobStepOutputTarget\"}", isOptional: true)]
        public virtual azurerm.MssqlJobStep.IMssqlJobStepOutputTarget? OutputTargetInput
        {
            get => GetInstanceProperty<azurerm.MssqlJobStep.IMssqlJobStepOutputTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryAttemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetryAttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryIntervalBackoffMultiplierInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetryIntervalBackoffMultiplierInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlScriptInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlScriptInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.MssqlJobStep.IMssqlJobStepTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.mssqlJobStep.MssqlJobStepTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialRetryIntervalSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialRetryIntervalSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobCredentialId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobCredentialId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobStepIndex", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double JobStepIndex
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobTargetGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobTargetGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumRetryIntervalSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumRetryIntervalSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryAttempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retryIntervalBackoffMultiplier", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryIntervalBackoffMultiplier
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlScript
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
