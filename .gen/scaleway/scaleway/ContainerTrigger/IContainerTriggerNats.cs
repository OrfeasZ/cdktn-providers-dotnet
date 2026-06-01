using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ContainerTrigger
{
    [JsiiInterface(nativeType: typeof(IContainerTriggerNats), fullyQualifiedName: "scaleway.containerTrigger.ContainerTriggerNats")]
    public interface IContainerTriggerNats
    {
        /// <summary>The content of the NATS credentials file that will be used to authenticate with the NATS server and subscribe to the specified subject.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#credentials_file_content ContainerTrigger#credentials_file_content}
        /// </remarks>
        [JsiiProperty(name: "credentialsFileContent", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialsFileContent
        {
            get;
        }

        /// <summary>The URLs of the NATS server (e.g., "nats://nats.mnq.fr-par.scaleway.com:4222").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#server_urls ContainerTrigger#server_urls}
        /// </remarks>
        [JsiiProperty(name: "serverUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ServerUrls
        {
            get;
        }

        /// <summary>NATS subject to subscribe to (e.g., "my-subject").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#subject ContainerTrigger#subject}
        /// </remarks>
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        string Subject
        {
            get;
        }

        /// <summary>ID of the mnq nats account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#account_id ContainerTrigger#account_id}
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

        /// <summary>Project ID of the project where the mnq nats exists, defaults to provider project_id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#project_id ContainerTrigger#project_id}
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

        /// <summary>Region where the mnq nats exists, defaults to function's region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#region ContainerTrigger#region}
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

        [JsiiTypeProxy(nativeType: typeof(IContainerTriggerNats), fullyQualifiedName: "scaleway.containerTrigger.ContainerTriggerNats")]
        internal sealed class _Proxy : DeputyBase, scaleway.ContainerTrigger.IContainerTriggerNats
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The content of the NATS credentials file that will be used to authenticate with the NATS server and subscribe to the specified subject.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#credentials_file_content ContainerTrigger#credentials_file_content}
            /// </remarks>
            [JsiiProperty(name: "credentialsFileContent", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialsFileContent
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The URLs of the NATS server (e.g., "nats://nats.mnq.fr-par.scaleway.com:4222").</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#server_urls ContainerTrigger#server_urls}
            /// </remarks>
            [JsiiProperty(name: "serverUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ServerUrls
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>NATS subject to subscribe to (e.g., "my-subject").</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#subject ContainerTrigger#subject}
            /// </remarks>
            [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
            public string Subject
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the mnq nats account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#account_id ContainerTrigger#account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Project ID of the project where the mnq nats exists, defaults to provider project_id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#project_id ContainerTrigger#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where the mnq nats exists, defaults to function's region.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#region ContainerTrigger#region}
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
