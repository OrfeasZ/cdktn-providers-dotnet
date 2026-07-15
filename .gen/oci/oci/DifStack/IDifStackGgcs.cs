using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackGgcs), fullyQualifiedName: "oci.difStack.DifStackGgcs")]
    public interface IDifStackGgcs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#ocpu DifStack#ocpu}.</summary>
        [JsiiProperty(name: "ocpu", typeJson: "{\"primitive\":\"number\"}")]
        double Ocpu
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#password_secret_id DifStack#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string PasswordSecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#subnet_id DifStack#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#artifact_object_storage_path DifStack#artifact_object_storage_path}.</summary>
        [JsiiProperty(name: "artifactObjectStoragePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArtifactObjectStoragePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>connections block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#connections DifStack#connections}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsConnections" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "connections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsConnections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Connections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#ogg_version DifStack#ogg_version}.</summary>
        [JsiiProperty(name: "oggVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OggVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#public_subnet_id DifStack#public_subnet_id}.</summary>
        [JsiiProperty(name: "publicSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicSubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#sources DifStack#sources}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsSources" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sources
        {
            get
            {
                return null;
            }
        }

        /// <summary>targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#targets DifStack#targets}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsTargets" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Targets
        {
            get
            {
                return null;
            }
        }

        /// <summary>users block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#users DifStack#users}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsUsers" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "users", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Users
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackGgcs), fullyQualifiedName: "oci.difStack.DifStackGgcs")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackGgcs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#ocpu DifStack#ocpu}.</summary>
            [JsiiProperty(name: "ocpu", typeJson: "{\"primitive\":\"number\"}")]
            public double Ocpu
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#password_secret_id DifStack#password_secret_id}.</summary>
            [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string PasswordSecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#subnet_id DifStack#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#artifact_object_storage_path DifStack#artifact_object_storage_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "artifactObjectStoragePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArtifactObjectStoragePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connections block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#connections DifStack#connections}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsConnections" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsConnections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Connections
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#ogg_version DifStack#ogg_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oggVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OggVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#public_subnet_id DifStack#public_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicSubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>sources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#sources DifStack#sources}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsSources" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Sources
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>targets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#targets DifStack#targets}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsTargets" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Targets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>users block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#users DifStack#users}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGgcsUsers" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "users", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGgcsUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Users
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
