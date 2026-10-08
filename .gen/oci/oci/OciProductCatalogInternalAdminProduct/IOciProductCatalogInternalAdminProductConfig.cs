using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OciProductCatalogInternalAdminProduct
{
    [JsiiInterface(nativeType: typeof(IOciProductCatalogInternalAdminProductConfig), fullyQualifiedName: "oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductConfig")]
    public interface IOciProductCatalogInternalAdminProductConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#compartment_id OciProductCatalogInternalAdminProduct#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#description OciProductCatalogInternalAdminProduct#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        string Description
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#name OciProductCatalogInternalAdminProduct#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#service_name OciProductCatalogInternalAdminProduct#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#backfill_eligibility OciProductCatalogInternalAdminProduct#backfill_eligibility}.</summary>
        [JsiiProperty(name: "backfillEligibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackfillEligibility
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#id OciProductCatalogInternalAdminProduct#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#is_excluded OciProductCatalogInternalAdminProduct#is_excluded}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isExcluded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsExcluded
        {
            get
            {
                return null;
            }
        }

        /// <summary>limits block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#limits OciProductCatalogInternalAdminProduct#limits}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductLimits" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Limits
        {
            get
            {
                return null;
            }
        }

        /// <summary>meters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#meters OciProductCatalogInternalAdminProduct#meters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductMeters" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "meters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductMeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Meters
        {
            get
            {
                return null;
            }
        }

        /// <summary>skus block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#skus OciProductCatalogInternalAdminProduct#skus}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductSkus" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "skus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductSkus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Skus
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#timeouts OciProductCatalogInternalAdminProduct#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOciProductCatalogInternalAdminProductConfig), fullyQualifiedName: "oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#compartment_id OciProductCatalogInternalAdminProduct#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#description OciProductCatalogInternalAdminProduct#description}.</summary>
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
            public string Description
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#name OciProductCatalogInternalAdminProduct#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#service_name OciProductCatalogInternalAdminProduct#service_name}.</summary>
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#backfill_eligibility OciProductCatalogInternalAdminProduct#backfill_eligibility}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backfillEligibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackfillEligibility
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#id OciProductCatalogInternalAdminProduct#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#is_excluded OciProductCatalogInternalAdminProduct#is_excluded}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isExcluded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsExcluded
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>limits block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#limits OciProductCatalogInternalAdminProduct#limits}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductLimits" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Limits
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>meters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#meters OciProductCatalogInternalAdminProduct#meters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductMeters" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "meters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductMeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Meters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>skus block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#skus OciProductCatalogInternalAdminProduct#skus}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductSkus" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductSkus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Skus
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#timeouts OciProductCatalogInternalAdminProduct#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductTimeouts\"}", isOptional: true)]
            public oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
