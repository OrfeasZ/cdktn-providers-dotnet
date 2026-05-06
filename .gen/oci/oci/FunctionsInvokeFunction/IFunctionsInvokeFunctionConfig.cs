using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsInvokeFunction
{
    [JsiiInterface(nativeType: typeof(IFunctionsInvokeFunctionConfig), fullyQualifiedName: "oci.functionsInvokeFunction.FunctionsInvokeFunctionConfig")]
    public interface IFunctionsInvokeFunctionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#function_id FunctionsInvokeFunction#function_id}.</summary>
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#base64_encode_content FunctionsInvokeFunction#base64_encode_content}.</summary>
        [JsiiProperty(name: "base64EncodeContent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Base64EncodeContent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#fn_intent FunctionsInvokeFunction#fn_intent}.</summary>
        [JsiiProperty(name: "fnIntent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FnIntent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#fn_invoke_type FunctionsInvokeFunction#fn_invoke_type}.</summary>
        [JsiiProperty(name: "fnInvokeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FnInvokeType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#id FunctionsInvokeFunction#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#input_body_source_path FunctionsInvokeFunction#input_body_source_path}.</summary>
        [JsiiProperty(name: "inputBodySourcePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputBodySourcePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#invoke_function_body FunctionsInvokeFunction#invoke_function_body}.</summary>
        [JsiiProperty(name: "invokeFunctionBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InvokeFunctionBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#invoke_function_body_base64_encoded FunctionsInvokeFunction#invoke_function_body_base64_encoded}.</summary>
        [JsiiProperty(name: "invokeFunctionBodyBase64Encoded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InvokeFunctionBodyBase64Encoded
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#is_dry_run FunctionsInvokeFunction#is_dry_run}.</summary>
        [JsiiProperty(name: "isDryRun", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDryRun
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#timeouts FunctionsInvokeFunction#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.functionsInvokeFunction.FunctionsInvokeFunctionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FunctionsInvokeFunction.IFunctionsInvokeFunctionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionsInvokeFunctionConfig), fullyQualifiedName: "oci.functionsInvokeFunction.FunctionsInvokeFunctionConfig")]
        internal sealed class _Proxy : DeputyBase, oci.FunctionsInvokeFunction.IFunctionsInvokeFunctionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#function_id FunctionsInvokeFunction#function_id}.</summary>
            [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#base64_encode_content FunctionsInvokeFunction#base64_encode_content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "base64EncodeContent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Base64EncodeContent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#fn_intent FunctionsInvokeFunction#fn_intent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fnIntent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FnIntent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#fn_invoke_type FunctionsInvokeFunction#fn_invoke_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fnInvokeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FnInvokeType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#id FunctionsInvokeFunction#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#input_body_source_path FunctionsInvokeFunction#input_body_source_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputBodySourcePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputBodySourcePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#invoke_function_body FunctionsInvokeFunction#invoke_function_body}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invokeFunctionBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InvokeFunctionBody
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#invoke_function_body_base64_encoded FunctionsInvokeFunction#invoke_function_body_base64_encoded}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invokeFunctionBodyBase64Encoded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InvokeFunctionBodyBase64Encoded
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#is_dry_run FunctionsInvokeFunction#is_dry_run}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isDryRun", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDryRun
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_invoke_function#timeouts FunctionsInvokeFunction#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.functionsInvokeFunction.FunctionsInvokeFunctionTimeouts\"}", isOptional: true)]
            public oci.FunctionsInvokeFunction.IFunctionsInvokeFunctionTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.FunctionsInvokeFunction.IFunctionsInvokeFunctionTimeouts?>();
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
