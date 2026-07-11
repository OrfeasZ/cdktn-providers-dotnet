using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.Image
{
    [JsiiInterface(nativeType: typeof(IImageDataDisk), fullyQualifiedName: "azurestack.image.ImageDataDisk")]
    public interface IImageDataDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/image#blob_uri Image#blob_uri}.</summary>
        [JsiiProperty(name: "blobUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlobUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/image#caching Image#caching}.</summary>
        [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Caching
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/image#lun Image#lun}.</summary>
        [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Lun
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/image#managed_disk_id Image#managed_disk_id}.</summary>
        [JsiiProperty(name: "managedDiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedDiskId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/image#size_gb Image#size_gb}.</summary>
        [JsiiProperty(name: "sizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SizeGb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImageDataDisk), fullyQualifiedName: "azurestack.image.ImageDataDisk")]
        internal sealed class _Proxy : DeputyBase, azurestack.Image.IImageDataDisk
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/image#blob_uri Image#blob_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blobUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlobUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/image#caching Image#caching}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Caching
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/image#lun Image#lun}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Lun
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/image#managed_disk_id Image#managed_disk_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedDiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedDiskId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/image#size_gb Image#size_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SizeGb
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
