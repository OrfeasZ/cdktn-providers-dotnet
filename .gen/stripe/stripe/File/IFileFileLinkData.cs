using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.File
{
    [JsiiInterface(nativeType: typeof(IFileFileLinkData), fullyQualifiedName: "stripe.file.FileFileLinkData")]
    public interface IFileFileLinkData
    {
        /// <summary>Set this to `true` to create a file link for the newly created file.</summary>
        /// <remarks>
        /// Creating a link is only possible when the file's <c>purpose</c> is one of the following: <c>business_icon</c>, <c>business_logo</c>, <c>customer_signature</c>, <c>dispute_evidence</c>, <c>issuing_regulatory_reporting</c>, <c>pci_document</c>, <c>tax_document_user_upload</c>, <c>terminal_android_apk</c>, or <c>terminal_reader_splashscreen</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/file#create File#create}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "create", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Create
        {
            get;
        }

        /// <summary>The link isn't available after this future timestamp.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/file#expires_at File#expires_at}
        /// </remarks>
        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpiresAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/file#metadata File#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFileFileLinkData), fullyQualifiedName: "stripe.file.FileFileLinkData")]
        internal sealed class _Proxy : DeputyBase, stripe.File.IFileFileLinkData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Set this to `true` to create a file link for the newly created file.</summary>
            /// <remarks>
            /// Creating a link is only possible when the file's <c>purpose</c> is one of the following: <c>business_icon</c>, <c>business_logo</c>, <c>customer_signature</c>, <c>dispute_evidence</c>, <c>issuing_regulatory_reporting</c>, <c>pci_document</c>, <c>tax_document_user_upload</c>, <c>terminal_android_apk</c>, or <c>terminal_reader_splashscreen</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/file#create File#create}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "create", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Create
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The link isn't available after this future timestamp.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/file#expires_at File#expires_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpiresAt
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/file#metadata File#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
