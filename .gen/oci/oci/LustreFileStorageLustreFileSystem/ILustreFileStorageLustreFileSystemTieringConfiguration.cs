using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LustreFileStorageLustreFileSystem
{
    [JsiiInterface(nativeType: typeof(ILustreFileStorageLustreFileSystemTieringConfiguration), fullyQualifiedName: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemTieringConfiguration")]
    public interface ILustreFileStorageLustreFileSystemTieringConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#is_enabled LustreFileStorageLustreFileSystem#is_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#policy_mode LustreFileStorageLustreFileSystem#policy_mode}.</summary>
        [JsiiProperty(name: "policyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#rules LustreFileStorageLustreFileSystem#rules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemTieringConfigurationRules" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemTieringConfigurationRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILustreFileStorageLustreFileSystemTieringConfiguration), fullyQualifiedName: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemTieringConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemTieringConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#is_enabled LustreFileStorageLustreFileSystem#is_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#policy_mode LustreFileStorageLustreFileSystem#policy_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#rules LustreFileStorageLustreFileSystem#rules}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemTieringConfigurationRules" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemTieringConfigurationRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rules
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
