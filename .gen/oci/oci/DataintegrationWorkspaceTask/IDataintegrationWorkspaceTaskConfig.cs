using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceTaskConfig), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfig")]
    public interface IDataintegrationWorkspaceTaskConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#identifier DataintegrationWorkspaceTask#identifier}.</summary>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        string Identifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#model_type DataintegrationWorkspaceTask#model_type}.</summary>
        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        string ModelType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#name DataintegrationWorkspaceTask#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>registry_metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#registry_metadata DataintegrationWorkspaceTask#registry_metadata}
        /// </remarks>
        [JsiiProperty(name: "registryMetadata", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskRegistryMetadata\"}")]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskRegistryMetadata RegistryMetadata
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#workspace_id DataintegrationWorkspaceTask#workspace_id}.</summary>
        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string WorkspaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#api_call_mode DataintegrationWorkspaceTask#api_call_mode}.</summary>
        [JsiiProperty(name: "apiCallMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiCallMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>auth_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#auth_config DataintegrationWorkspaceTask#auth_config}
        /// </remarks>
        [JsiiProperty(name: "authConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskAuthConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskAuthConfig? AuthConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>cancel_rest_call_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#cancel_rest_call_config DataintegrationWorkspaceTask#cancel_rest_call_config}
        /// </remarks>
        [JsiiProperty(name: "cancelRestCallConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfig? CancelRestCallConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>config_provider_delegate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_provider_delegate DataintegrationWorkspaceTask#config_provider_delegate}
        /// </remarks>
        [JsiiProperty(name: "configProviderDelegate", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegate? ConfigProviderDelegate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#description DataintegrationWorkspaceTask#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>execute_rest_call_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#execute_rest_call_config DataintegrationWorkspaceTask#execute_rest_call_config}
        /// </remarks>
        [JsiiProperty(name: "executeRestCallConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfig? ExecuteRestCallConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#id DataintegrationWorkspaceTask#id}.</summary>
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

        /// <summary>input_ports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#input_ports DataintegrationWorkspaceTask#input_ports}
        /// </remarks>
        [JsiiProperty(name: "inputPorts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskInputPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InputPorts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#is_single_load DataintegrationWorkspaceTask#is_single_load}.</summary>
        [JsiiProperty(name: "isSingleLoad", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSingleLoad
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#key DataintegrationWorkspaceTask#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#model_version DataintegrationWorkspaceTask#model_version}.</summary>
        [JsiiProperty(name: "modelVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#object_status DataintegrationWorkspaceTask#object_status}.</summary>
        [JsiiProperty(name: "objectStatus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ObjectStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>op_config_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#op_config_values DataintegrationWorkspaceTask#op_config_values}
        /// </remarks>
        [JsiiProperty(name: "opConfigValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValues\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValues? OpConfigValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#operation DataintegrationWorkspaceTask#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Operation
        {
            get
            {
                return null;
            }
        }

        /// <summary>output_ports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#output_ports DataintegrationWorkspaceTask#output_ports}
        /// </remarks>
        [JsiiProperty(name: "outputPorts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOutputPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OutputPorts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parallel_load_limit DataintegrationWorkspaceTask#parallel_load_limit}.</summary>
        [JsiiProperty(name: "parallelLoadLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ParallelLoadLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parameters DataintegrationWorkspaceTask#parameters}
        /// </remarks>
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>parent_ref block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parent_ref DataintegrationWorkspaceTask#parent_ref}
        /// </remarks>
        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParentRef\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParentRef? ParentRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>poll_rest_call_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#poll_rest_call_config DataintegrationWorkspaceTask#poll_rest_call_config}
        /// </remarks>
        [JsiiProperty(name: "pollRestCallConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfig? PollRestCallConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#timeouts DataintegrationWorkspaceTask#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>typed_expressions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#typed_expressions DataintegrationWorkspaceTask#typed_expressions}
        /// </remarks>
        [JsiiProperty(name: "typedExpressions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TypedExpressions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceTaskConfig), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#identifier DataintegrationWorkspaceTask#identifier}.</summary>
            [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
            public string Identifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#model_type DataintegrationWorkspaceTask#model_type}.</summary>
            [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#name DataintegrationWorkspaceTask#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>registry_metadata block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#registry_metadata DataintegrationWorkspaceTask#registry_metadata}
            /// </remarks>
            [JsiiProperty(name: "registryMetadata", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskRegistryMetadata\"}")]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskRegistryMetadata RegistryMetadata
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskRegistryMetadata>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#workspace_id DataintegrationWorkspaceTask#workspace_id}.</summary>
            [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#api_call_mode DataintegrationWorkspaceTask#api_call_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "apiCallMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiCallMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>auth_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#auth_config DataintegrationWorkspaceTask#auth_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskAuthConfig\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskAuthConfig? AuthConfig
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskAuthConfig?>();
            }

            /// <summary>cancel_rest_call_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#cancel_rest_call_config DataintegrationWorkspaceTask#cancel_rest_call_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cancelRestCallConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfig\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfig? CancelRestCallConfig
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfig?>();
            }

            /// <summary>config_provider_delegate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_provider_delegate DataintegrationWorkspaceTask#config_provider_delegate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configProviderDelegate", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegate\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegate? ConfigProviderDelegate
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#description DataintegrationWorkspaceTask#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>execute_rest_call_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#execute_rest_call_config DataintegrationWorkspaceTask#execute_rest_call_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executeRestCallConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfig\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfig? ExecuteRestCallConfig
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#id DataintegrationWorkspaceTask#id}.</summary>
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

            /// <summary>input_ports block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#input_ports DataintegrationWorkspaceTask#input_ports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputPorts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskInputPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InputPorts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#is_single_load DataintegrationWorkspaceTask#is_single_load}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSingleLoad", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSingleLoad
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#key DataintegrationWorkspaceTask#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#model_version DataintegrationWorkspaceTask#model_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#object_status DataintegrationWorkspaceTask#object_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectStatus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ObjectStatus
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>op_config_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#op_config_values DataintegrationWorkspaceTask#op_config_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "opConfigValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValues\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValues? OpConfigValues
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValues?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#operation DataintegrationWorkspaceTask#operation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Operation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>output_ports block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#output_ports DataintegrationWorkspaceTask#output_ports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outputPorts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOutputPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OutputPorts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parallel_load_limit DataintegrationWorkspaceTask#parallel_load_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parallelLoadLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ParallelLoadLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parameters DataintegrationWorkspaceTask#parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Parameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parent_ref block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parent_ref DataintegrationWorkspaceTask#parent_ref}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParentRef\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParentRef? ParentRef
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParentRef?>();
            }

            /// <summary>poll_rest_call_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#poll_rest_call_config DataintegrationWorkspaceTask#poll_rest_call_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pollRestCallConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfig\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfig? PollRestCallConfig
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfig?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#timeouts DataintegrationWorkspaceTask#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTimeouts\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTimeouts?>();
            }

            /// <summary>typed_expressions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#typed_expressions DataintegrationWorkspaceTask#typed_expressions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "typedExpressions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TypedExpressions
            {
                get => GetInstanceProperty<object?>();
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
