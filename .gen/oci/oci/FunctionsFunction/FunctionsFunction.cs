using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function oci_functions_function}.</summary>
    [JsiiClass(nativeType: typeof(oci.FunctionsFunction.FunctionsFunction), fullyQualifiedName: "oci.functionsFunction.FunctionsFunction", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.functionsFunction.FunctionsFunctionConfig\"}}]")]
    public class FunctionsFunction : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function oci_functions_function} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FunctionsFunction(Constructs.Construct scope, string id, oci.FunctionsFunction.IFunctionsFunctionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.FunctionsFunction.IFunctionsFunctionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionsFunction(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionsFunction(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a FunctionsFunction resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FunctionsFunction to import.</param>
        /// <param name="importFromId">The id of the existing FunctionsFunction that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FunctionsFunction to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FunctionsFunction to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FunctionsFunction that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FunctionsFunction to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.FunctionsFunction.FunctionsFunction), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFailureDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.functionsFunction.FunctionsFunctionFailureDestination\"}}]")]
        public virtual void PutFailureDestination(oci.FunctionsFunction.IFunctionsFunctionFailureDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FunctionsFunction.IFunctionsFunctionFailureDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProvisionedConcurrencyConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.functionsFunction.FunctionsFunctionProvisionedConcurrencyConfig\"}}]")]
        public virtual void PutProvisionedConcurrencyConfig(oci.FunctionsFunction.IFunctionsFunctionProvisionedConcurrencyConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FunctionsFunction.IFunctionsFunctionProvisionedConcurrencyConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetails\"}}]")]
        public virtual void PutSourceDetails(oci.FunctionsFunction.IFunctionsFunctionSourceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FunctionsFunction.IFunctionsFunctionSourceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSuccessDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSuccessDestination\"}}]")]
        public virtual void PutSuccessDestination(oci.FunctionsFunction.IFunctionsFunctionSuccessDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FunctionsFunction.IFunctionsFunctionSuccessDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.functionsFunction.FunctionsFunctionTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.FunctionsFunction.IFunctionsFunctionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FunctionsFunction.IFunctionsFunctionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTraceConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.functionsFunction.FunctionsFunctionTraceConfig\"}}]")]
        public virtual void PutTraceConfig(oci.FunctionsFunction.IFunctionsFunctionTraceConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FunctionsFunction.IFunctionsFunctionTraceConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfig")]
        public virtual void ResetConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDetachedModeTimeoutInSeconds")]
        public virtual void ResetDetachedModeTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailureDestination")]
        public virtual void ResetFailureDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImage")]
        public virtual void ResetImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageDigest")]
        public virtual void ResetImageDigest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvisionedConcurrencyConfig")]
        public virtual void ResetProvisionedConcurrencyConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDetails")]
        public virtual void ResetSourceDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccessDestination")]
        public virtual void ResetSuccessDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutInSeconds")]
        public virtual void ResetTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTraceConfig")]
        public virtual void ResetTraceConfig()
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
        = GetStaticProperty<string>(typeof(oci.FunctionsFunction.FunctionsFunction))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failureDestination", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionFailureDestinationOutputReference\"}")]
        public virtual oci.FunctionsFunction.FunctionsFunctionFailureDestinationOutputReference FailureDestination
        {
            get => GetInstanceProperty<oci.FunctionsFunction.FunctionsFunctionFailureDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "invokeEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvokeEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisionedConcurrencyConfig", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionProvisionedConcurrencyConfigOutputReference\"}")]
        public virtual oci.FunctionsFunction.FunctionsFunctionProvisionedConcurrencyConfigOutputReference ProvisionedConcurrencyConfig
        {
            get => GetInstanceProperty<oci.FunctionsFunction.FunctionsFunctionProvisionedConcurrencyConfigOutputReference>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsOutputReference\"}")]
        public virtual oci.FunctionsFunction.FunctionsFunctionSourceDetailsOutputReference SourceDetails
        {
            get => GetInstanceProperty<oci.FunctionsFunction.FunctionsFunctionSourceDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "successDestination", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSuccessDestinationOutputReference\"}")]
        public virtual oci.FunctionsFunction.FunctionsFunctionSuccessDestinationOutputReference SuccessDestination
        {
            get => GetInstanceProperty<oci.FunctionsFunction.FunctionsFunctionSuccessDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionTimeoutsOutputReference\"}")]
        public virtual oci.FunctionsFunction.FunctionsFunctionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.FunctionsFunction.FunctionsFunctionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "traceConfig", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionTraceConfigOutputReference\"}")]
        public virtual oci.FunctionsFunction.FunctionsFunctionTraceConfigOutputReference TraceConfig
        {
            get => GetInstanceProperty<oci.FunctionsFunction.FunctionsFunctionTraceConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ConfigInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detachedModeTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DetachedModeTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failureDestinationInput", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionFailureDestination\"}", isOptional: true)]
        public virtual oci.FunctionsFunction.IFunctionsFunctionFailureDestination? FailureDestinationInput
        {
            get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionFailureDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageDigestInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageDigestInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInMbsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemoryInMbsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisionedConcurrencyConfigInput", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionProvisionedConcurrencyConfig\"}", isOptional: true)]
        public virtual oci.FunctionsFunction.IFunctionsFunctionProvisionedConcurrencyConfig? ProvisionedConcurrencyConfigInput
        {
            get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionProvisionedConcurrencyConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDetailsInput", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetails\"}", isOptional: true)]
        public virtual oci.FunctionsFunction.IFunctionsFunctionSourceDetails? SourceDetailsInput
        {
            get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionSourceDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successDestinationInput", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSuccessDestination\"}", isOptional: true)]
        public virtual oci.FunctionsFunction.IFunctionsFunctionSuccessDestination? SuccessDestinationInput
        {
            get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionSuccessDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.functionsFunction.FunctionsFunctionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "traceConfigInput", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionTraceConfig\"}", isOptional: true)]
        public virtual oci.FunctionsFunction.IFunctionsFunctionTraceConfig? TraceConfigInput
        {
            get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionTraceConfig?>();
        }

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "config", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Config
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "detachedModeTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DetachedModeTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageDigest
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemoryInMbs
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
