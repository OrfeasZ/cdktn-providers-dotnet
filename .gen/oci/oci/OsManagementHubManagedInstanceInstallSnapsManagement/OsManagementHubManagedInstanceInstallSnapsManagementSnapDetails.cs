using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceInstallSnapsManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementSnapDetails")]
    public class OsManagementHubManagedInstanceInstallSnapsManagementSnapDetails : oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementSnapDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#name OsManagementHubManagedInstanceInstallSnapsManagement#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#channel OsManagementHubManagedInstanceInstallSnapsManagement#channel}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Channel
        {
            get;
            set;
        }

        private object? _isSigned;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#is_signed OsManagementHubManagedInstanceInstallSnapsManagement#is_signed}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isSigned", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSigned
        {
            get => _isSigned;
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
                _isSigned = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#mode OsManagementHubManagedInstanceInstallSnapsManagement#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#revision OsManagementHubManagedInstanceInstallSnapsManagement#revision}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Revision
        {
            get;
            set;
        }
    }
}
