using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageVersion
{
    [JsiiInterface(nativeType: typeof(ISharedImageVersionUefiAdditionalSignatures), fullyQualifiedName: "azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignatures")]
    public interface ISharedImageVersionUefiAdditionalSignatures
    {
        /// <summary>db block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.12.0/docs/resources/shared_image_version#db SharedImageVersion#db}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDb" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "db", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDb\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Db
        {
            get
            {
                return null;
            }
        }

        /// <summary>dbx block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.12.0/docs/resources/shared_image_version#dbx SharedImageVersion#dbx}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDbx" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dbx", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDbx\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Dbx
        {
            get
            {
                return null;
            }
        }

        /// <summary>kek block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.12.0/docs/resources/shared_image_version#kek SharedImageVersion#kek}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesKek" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "kek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesKek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Kek
        {
            get
            {
                return null;
            }
        }

        /// <summary>pk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.12.0/docs/resources/shared_image_version#pk SharedImageVersion#pk}
        /// </remarks>
        [JsiiProperty(name: "pk", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesPk\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesPk? Pk
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISharedImageVersionUefiAdditionalSignatures), fullyQualifiedName: "azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignatures")]
        internal sealed class _Proxy : DeputyBase, azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>db block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.12.0/docs/resources/shared_image_version#db SharedImageVersion#db}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDb" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "db", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDb\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Db
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>dbx block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.12.0/docs/resources/shared_image_version#dbx SharedImageVersion#dbx}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDbx" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbx", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDbx\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Dbx
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>kek block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.12.0/docs/resources/shared_image_version#kek SharedImageVersion#kek}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesKek" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesKek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Kek
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>pk block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.12.0/docs/resources/shared_image_version#pk SharedImageVersion#pk}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pk", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesPk\"}", isOptional: true)]
            public azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesPk? Pk
            {
                get => GetInstanceProperty<azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesPk?>();
            }
        }
    }
}
