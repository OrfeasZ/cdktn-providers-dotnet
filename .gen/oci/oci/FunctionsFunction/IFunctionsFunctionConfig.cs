using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    [JsiiInterface(nativeType: typeof(IFunctionsFunctionConfig), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionConfig")]
    public interface IFunctionsFunctionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#application_id FunctionsFunction#application_id}.</summary>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#display_name FunctionsFunction#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#memory_in_mbs FunctionsFunction#memory_in_mbs}.</summary>
        [JsiiProperty(name: "memoryInMbs", typeJson: "{\"primitive\":\"string\"}")]
        string MemoryInMbs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#config FunctionsFunction#config}.</summary>
        [JsiiProperty(name: "config", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Config
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#defined_tags FunctionsFunction#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#detached_mode_timeout_in_seconds FunctionsFunction#detached_mode_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "detachedModeTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DetachedModeTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>failure_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#failure_destination FunctionsFunction#failure_destination}
        /// </remarks>
        [JsiiProperty(name: "failureDestination", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionFailureDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FunctionsFunction.IFunctionsFunctionFailureDestination? FailureDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#freeform_tags FunctionsFunction#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#id FunctionsFunction#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#image FunctionsFunction#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Image
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#image_digest FunctionsFunction#image_digest}.</summary>
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageDigest
        {
            get
            {
                return null;
            }
        }

        /// <summary>provisioned_concurrency_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#provisioned_concurrency_config FunctionsFunction#provisioned_concurrency_config}
        /// </remarks>
        [JsiiProperty(name: "provisionedConcurrencyConfig", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionProvisionedConcurrencyConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FunctionsFunction.IFunctionsFunctionProvisionedConcurrencyConfig? ProvisionedConcurrencyConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#source_details FunctionsFunction#source_details}
        /// </remarks>
        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FunctionsFunction.IFunctionsFunctionSourceDetails? SourceDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>success_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#success_destination FunctionsFunction#success_destination}
        /// </remarks>
        [JsiiProperty(name: "successDestination", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSuccessDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FunctionsFunction.IFunctionsFunctionSuccessDestination? SuccessDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#timeout_in_seconds FunctionsFunction#timeout_in_seconds}.</summary>
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#timeouts FunctionsFunction#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FunctionsFunction.IFunctionsFunctionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>trace_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#trace_config FunctionsFunction#trace_config}
        /// </remarks>
        [JsiiProperty(name: "traceConfig", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionTraceConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FunctionsFunction.IFunctionsFunctionTraceConfig? TraceConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionsFunctionConfig), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionConfig")]
        internal sealed class _Proxy : DeputyBase, oci.FunctionsFunction.IFunctionsFunctionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#application_id FunctionsFunction#application_id}.</summary>
            [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#display_name FunctionsFunction#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#memory_in_mbs FunctionsFunction#memory_in_mbs}.</summary>
            [JsiiProperty(name: "memoryInMbs", typeJson: "{\"primitive\":\"string\"}")]
            public string MemoryInMbs
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#config FunctionsFunction#config}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "config", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Config
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#defined_tags FunctionsFunction#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#detached_mode_timeout_in_seconds FunctionsFunction#detached_mode_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "detachedModeTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DetachedModeTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>failure_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#failure_destination FunctionsFunction#failure_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failureDestination", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionFailureDestination\"}", isOptional: true)]
            public oci.FunctionsFunction.IFunctionsFunctionFailureDestination? FailureDestination
            {
                get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionFailureDestination?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#freeform_tags FunctionsFunction#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#id FunctionsFunction#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#image FunctionsFunction#image}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Image
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#image_digest FunctionsFunction#image_digest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageDigest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>provisioned_concurrency_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#provisioned_concurrency_config FunctionsFunction#provisioned_concurrency_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisionedConcurrencyConfig", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionProvisionedConcurrencyConfig\"}", isOptional: true)]
            public oci.FunctionsFunction.IFunctionsFunctionProvisionedConcurrencyConfig? ProvisionedConcurrencyConfig
            {
                get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionProvisionedConcurrencyConfig?>();
            }

            /// <summary>source_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#source_details FunctionsFunction#source_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetails\"}", isOptional: true)]
            public oci.FunctionsFunction.IFunctionsFunctionSourceDetails? SourceDetails
            {
                get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionSourceDetails?>();
            }

            /// <summary>success_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#success_destination FunctionsFunction#success_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "successDestination", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSuccessDestination\"}", isOptional: true)]
            public oci.FunctionsFunction.IFunctionsFunctionSuccessDestination? SuccessDestination
            {
                get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionSuccessDestination?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#timeout_in_seconds FunctionsFunction#timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#timeouts FunctionsFunction#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionTimeouts\"}", isOptional: true)]
            public oci.FunctionsFunction.IFunctionsFunctionTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionTimeouts?>();
            }

            /// <summary>trace_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#trace_config FunctionsFunction#trace_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "traceConfig", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionTraceConfig\"}", isOptional: true)]
            public oci.FunctionsFunction.IFunctionsFunctionTraceConfig? TraceConfig
            {
                get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionTraceConfig?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
