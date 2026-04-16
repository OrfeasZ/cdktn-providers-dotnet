using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.FunctionTrigger
{
    [JsiiInterface(nativeType: typeof(IFunctionTriggerSqs), fullyQualifiedName: "scaleway.functionTrigger.FunctionTriggerSqs")]
    public interface IFunctionTriggerSqs
    {
        /// <summary>Name of the queue.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#queue FunctionTrigger#queue}
        /// </remarks>
        [JsiiProperty(name: "queue", typeJson: "{\"primitive\":\"string\"}")]
        string Queue
        {
            get;
        }

        /// <summary>ID of the mnq namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#namespace_id FunctionTrigger#namespace_id}
        /// </remarks>
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamespaceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Project ID of the project where the mnq sqs exists, defaults to provider project_id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#project_id FunctionTrigger#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where the mnq sqs exists, defaults to function's region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#region FunctionTrigger#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionTriggerSqs), fullyQualifiedName: "scaleway.functionTrigger.FunctionTriggerSqs")]
        internal sealed class _Proxy : DeputyBase, scaleway.FunctionTrigger.IFunctionTriggerSqs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the queue.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#queue FunctionTrigger#queue}
            /// </remarks>
            [JsiiProperty(name: "queue", typeJson: "{\"primitive\":\"string\"}")]
            public string Queue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the mnq namespace.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#namespace_id FunctionTrigger#namespace_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamespaceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Project ID of the project where the mnq sqs exists, defaults to provider project_id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#project_id FunctionTrigger#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where the mnq sqs exists, defaults to function's region.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#region FunctionTrigger#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
