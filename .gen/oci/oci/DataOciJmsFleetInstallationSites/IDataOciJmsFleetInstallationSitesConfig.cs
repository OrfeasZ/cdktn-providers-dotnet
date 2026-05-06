using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsFleetInstallationSites
{
    [JsiiInterface(nativeType: typeof(IDataOciJmsFleetInstallationSitesConfig), fullyQualifiedName: "oci.dataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesConfig")]
    public interface IDataOciJmsFleetInstallationSitesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#fleet_id DataOciJmsFleetInstallationSites#fleet_id}.</summary>
        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        string FleetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#application_id DataOciJmsFleetInstallationSites#application_id}.</summary>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#filter DataOciJmsFleetInstallationSites#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#id DataOciJmsFleetInstallationSites#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#installation_path DataOciJmsFleetInstallationSites#installation_path}.</summary>
        [JsiiProperty(name: "installationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstallationPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#jre_distribution DataOciJmsFleetInstallationSites#jre_distribution}.</summary>
        [JsiiProperty(name: "jreDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JreDistribution
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#jre_security_status DataOciJmsFleetInstallationSites#jre_security_status}.</summary>
        [JsiiProperty(name: "jreSecurityStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JreSecurityStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#jre_vendor DataOciJmsFleetInstallationSites#jre_vendor}.</summary>
        [JsiiProperty(name: "jreVendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JreVendor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#jre_version DataOciJmsFleetInstallationSites#jre_version}.</summary>
        [JsiiProperty(name: "jreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JreVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#managed_instance_id DataOciJmsFleetInstallationSites#managed_instance_id}.</summary>
        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedInstanceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#os_family DataOciJmsFleetInstallationSites#os_family}.</summary>
        [JsiiProperty(name: "osFamily", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OsFamily
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#path_contains DataOciJmsFleetInstallationSites#path_contains}.</summary>
        [JsiiProperty(name: "pathContains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PathContains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#time_end DataOciJmsFleetInstallationSites#time_end}.</summary>
        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeEnd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#time_start DataOciJmsFleetInstallationSites#time_start}.</summary>
        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeStart
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciJmsFleetInstallationSitesConfig), fullyQualifiedName: "oci.dataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciJmsFleetInstallationSites.IDataOciJmsFleetInstallationSitesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#fleet_id DataOciJmsFleetInstallationSites#fleet_id}.</summary>
            [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
            public string FleetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#application_id DataOciJmsFleetInstallationSites#application_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#filter DataOciJmsFleetInstallationSites#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#id DataOciJmsFleetInstallationSites#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#installation_path DataOciJmsFleetInstallationSites#installation_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "installationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstallationPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#jre_distribution DataOciJmsFleetInstallationSites#jre_distribution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jreDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JreDistribution
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#jre_security_status DataOciJmsFleetInstallationSites#jre_security_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jreSecurityStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JreSecurityStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#jre_vendor DataOciJmsFleetInstallationSites#jre_vendor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jreVendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JreVendor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#jre_version DataOciJmsFleetInstallationSites#jre_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JreVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#managed_instance_id DataOciJmsFleetInstallationSites#managed_instance_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedInstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#os_family DataOciJmsFleetInstallationSites#os_family}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "osFamily", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OsFamily
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#path_contains DataOciJmsFleetInstallationSites#path_contains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pathContains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PathContains
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#time_end DataOciJmsFleetInstallationSites#time_end}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeEnd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_installation_sites#time_start DataOciJmsFleetInstallationSites#time_start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeStart
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
