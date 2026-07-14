using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolMount), fullyQualifiedName: "azurerm.batchPool.BatchPoolMount")]
    public interface IBatchPoolMount
    {
        /// <summary>azure_blob_file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/batch_pool#azure_blob_file_system BatchPool#azure_blob_file_system}
        /// </remarks>
        [JsiiProperty(name: "azureBlobFileSystem", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureBlobFileSystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.BatchPool.IBatchPoolMountAzureBlobFileSystem? AzureBlobFileSystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>azure_file_share block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/batch_pool#azure_file_share BatchPool#azure_file_share}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolMountAzureFileShare" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "azureFileShare", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureFileShare\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AzureFileShare
        {
            get
            {
                return null;
            }
        }

        /// <summary>cifs_mount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/batch_pool#cifs_mount BatchPool#cifs_mount}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolMountCifsMount" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "cifsMount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountCifsMount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CifsMount
        {
            get
            {
                return null;
            }
        }

        /// <summary>nfs_mount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/batch_pool#nfs_mount BatchPool#nfs_mount}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolMountNfsMount" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "nfsMount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountNfsMount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NfsMount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolMount), fullyQualifiedName: "azurerm.batchPool.BatchPoolMount")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolMount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>azure_blob_file_system block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/batch_pool#azure_blob_file_system BatchPool#azure_blob_file_system}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureBlobFileSystem", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureBlobFileSystem\"}", isOptional: true)]
            public azurerm.BatchPool.IBatchPoolMountAzureBlobFileSystem? AzureBlobFileSystem
            {
                get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolMountAzureBlobFileSystem?>();
            }

            /// <summary>azure_file_share block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/batch_pool#azure_file_share BatchPool#azure_file_share}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolMountAzureFileShare" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureFileShare", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureFileShare\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AzureFileShare
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cifs_mount block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/batch_pool#cifs_mount BatchPool#cifs_mount}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolMountCifsMount" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cifsMount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountCifsMount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CifsMount
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>nfs_mount block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/batch_pool#nfs_mount BatchPool#nfs_mount}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.BatchPool.IBatchPoolMountNfsMount" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nfsMount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountNfsMount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NfsMount
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
