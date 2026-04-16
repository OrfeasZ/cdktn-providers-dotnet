using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.FunctionTrigger
{
    [JsiiInterface(nativeType: typeof(IFunctionTriggerNats), fullyQualifiedName: "scaleway.functionTrigger.FunctionTriggerNats")]
    public interface IFunctionTriggerNats
    {
        /// <summary>Subject to listen to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#subject FunctionTrigger#subject}
        /// </remarks>
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        string Subject
        {
            get;
        }

        /// <summary>ID of the mnq nats account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#account_id FunctionTrigger#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
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

        [JsiiTypeProxy(nativeType: typeof(IFunctionTriggerNats), fullyQualifiedName: "scaleway.functionTrigger.FunctionTriggerNats")]
        internal sealed class _Proxy : DeputyBase, scaleway.FunctionTrigger.IFunctionTriggerNats
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Subject to listen to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#subject FunctionTrigger#subject}
            /// </remarks>
            [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
            public string Subject
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the mnq nats account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/function_trigger#account_id FunctionTrigger#account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
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
