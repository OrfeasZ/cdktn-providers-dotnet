using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageJob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/ai_language_job oci_ai_language_job}.</summary>
    [JsiiClass(nativeType: typeof(oci.AiLanguageJob.AiLanguageJob), fullyQualifiedName: "oci.aiLanguageJob.AiLanguageJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobConfig\"}}]")]
    public class AiLanguageJob : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/ai_language_job oci_ai_language_job} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AiLanguageJob(Constructs.Construct scope, string id, oci.AiLanguageJob.IAiLanguageJobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.AiLanguageJob.IAiLanguageJobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiLanguageJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiLanguageJob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AiLanguageJob resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AiLanguageJob to import.</param>
        /// <param name="importFromId">The id of the existing AiLanguageJob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AiLanguageJob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AiLanguageJob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/ai_language_job#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AiLanguageJob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AiLanguageJob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.AiLanguageJob.AiLanguageJob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putInputConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobInputConfiguration\"}}]")]
        public virtual void PutInputConfiguration(oci.AiLanguageJob.IAiLanguageJobInputConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageJob.IAiLanguageJobInputConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInputLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobInputLocation\"}}]")]
        public virtual void PutInputLocation(oci.AiLanguageJob.IAiLanguageJobInputLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageJob.IAiLanguageJobInputLocation)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.AiLanguageJob.IAiLanguageJobModelMetadataDetails" />)[]</param>
        [JsiiMethod(name: "putModelMetadataDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobModelMetadataDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutModelMetadataDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.AiLanguageJob.IAiLanguageJobModelMetadataDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiLanguageJob.IAiLanguageJobModelMetadataDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiLanguageJob.IAiLanguageJobModelMetadataDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutputLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobOutputLocation\"}}]")]
        public virtual void PutOutputLocation(oci.AiLanguageJob.IAiLanguageJobOutputLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageJob.IAiLanguageJobOutputLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.AiLanguageJob.IAiLanguageJobTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageJob.IAiLanguageJobTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputConfiguration")]
        public virtual void ResetInputConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.AiLanguageJob.AiLanguageJob))!;

        [JsiiProperty(name: "completedDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompletedDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failedDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailedDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "inputConfiguration", typeJson: "{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobInputConfigurationOutputReference\"}")]
        public virtual oci.AiLanguageJob.AiLanguageJobInputConfigurationOutputReference InputConfiguration
        {
            get => GetInstanceProperty<oci.AiLanguageJob.AiLanguageJobInputConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "inputLocation", typeJson: "{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobInputLocationOutputReference\"}")]
        public virtual oci.AiLanguageJob.AiLanguageJobInputLocationOutputReference InputLocation
        {
            get => GetInstanceProperty<oci.AiLanguageJob.AiLanguageJobInputLocationOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelMetadataDetails", typeJson: "{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobModelMetadataDetailsList\"}")]
        public virtual oci.AiLanguageJob.AiLanguageJobModelMetadataDetailsList ModelMetadataDetails
        {
            get => GetInstanceProperty<oci.AiLanguageJob.AiLanguageJobModelMetadataDetailsList>()!;
        }

        [JsiiProperty(name: "outputLocation", typeJson: "{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobOutputLocationOutputReference\"}")]
        public virtual oci.AiLanguageJob.AiLanguageJobOutputLocationOutputReference OutputLocation
        {
            get => GetInstanceProperty<oci.AiLanguageJob.AiLanguageJobOutputLocationOutputReference>()!;
        }

        [JsiiProperty(name: "pendingDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PendingDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "percentComplete", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PercentComplete
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAccepted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAccepted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCompleted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCompleted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobTimeoutsOutputReference\"}")]
        public virtual oci.AiLanguageJob.AiLanguageJobTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.AiLanguageJob.AiLanguageJobTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ttlInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TtlInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "warningsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WarningsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
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
        [JsiiProperty(name: "inputConfigurationInput", typeJson: "{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobInputConfiguration\"}", isOptional: true)]
        public virtual oci.AiLanguageJob.IAiLanguageJobInputConfiguration? InputConfigurationInput
        {
            get => GetInstanceProperty<oci.AiLanguageJob.IAiLanguageJobInputConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputLocationInput", typeJson: "{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobInputLocation\"}", isOptional: true)]
        public virtual oci.AiLanguageJob.IAiLanguageJobInputLocation? InputLocationInput
        {
            get => GetInstanceProperty<oci.AiLanguageJob.IAiLanguageJobInputLocation?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.AiLanguageJob.IAiLanguageJobModelMetadataDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelMetadataDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobModelMetadataDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ModelMetadataDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputLocationInput", typeJson: "{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobOutputLocation\"}", isOptional: true)]
        public virtual oci.AiLanguageJob.IAiLanguageJobOutputLocation? OutputLocationInput
        {
            get => GetInstanceProperty<oci.AiLanguageJob.IAiLanguageJobOutputLocation?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.AiLanguageJob.IAiLanguageJobTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.aiLanguageJob.AiLanguageJobTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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
    }
}
