using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LustreFileStorageLustreFileSystem
{
    [JsiiByValue(fqn: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemTieringConfiguration")]
    public class LustreFileStorageLustreFileSystemTieringConfiguration : oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemTieringConfiguration
    {
        private object? _isEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/lustre_file_storage_lustre_file_system#is_enabled LustreFileStorageLustreFileSystem#is_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/lustre_file_storage_lustre_file_system#policy_mode LustreFileStorageLustreFileSystem#policy_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyMode
        {
            get;
            set;
        }

        private object? _rules;

        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/lustre_file_storage_lustre_file_system#rules LustreFileStorageLustreFileSystem#rules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemTieringConfigurationRules" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemTieringConfigurationRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Rules
        {
            get => _rules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemTieringConfigurationRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemTieringConfigurationRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rules = value;
            }
        }
    }
}
