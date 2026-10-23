using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageVersion
{
    [JsiiByValue(fqn: "azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignatures")]
    public class SharedImageVersionUefiAdditionalSignatures : azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures
    {
        private object? _db;

        /// <summary>db block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.11.0/docs/resources/shared_image_version#db SharedImageVersion#db}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDb" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "db", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDb\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Db
        {
            get => _db;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDb[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDb).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _db = value;
            }
        }

        private object? _dbx;

        /// <summary>dbx block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.11.0/docs/resources/shared_image_version#dbx SharedImageVersion#dbx}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDbx" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbx", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDbx\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Dbx
        {
            get => _dbx;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDbx[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDbx).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dbx = value;
            }
        }

        private object? _kek;

        /// <summary>kek block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.11.0/docs/resources/shared_image_version#kek SharedImageVersion#kek}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesKek" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesKek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Kek
        {
            get => _kek;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesKek[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesKek).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _kek = value;
            }
        }

        /// <summary>pk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.11.0/docs/resources/shared_image_version#pk SharedImageVersion#pk}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pk", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesPk\"}", isOptional: true)]
        public azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesPk? Pk
        {
            get;
            set;
        }
    }
}
