using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxWindowsFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxWindowsFileSystem.FsxWindowsFileSystemSelfManagedActiveDirectory")]
    public class FsxWindowsFileSystemSelfManagedActiveDirectory : aws.FsxWindowsFileSystem.IFsxWindowsFileSystemSelfManagedActiveDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_windows_file_system#dns_ips FsxWindowsFileSystem#dns_ips}.</summary>
        [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DnsIps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_windows_file_system#domain_name FsxWindowsFileSystem#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_windows_file_system#domain_join_service_account_secret FsxWindowsFileSystem#domain_join_service_account_secret}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainJoinServiceAccountSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DomainJoinServiceAccountSecret
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_windows_file_system#file_system_administrators_group FsxWindowsFileSystem#file_system_administrators_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemAdministratorsGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileSystemAdministratorsGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_windows_file_system#organizational_unit_distinguished_name FsxWindowsFileSystem#organizational_unit_distinguished_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationalUnitDistinguishedName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrganizationalUnitDistinguishedName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_windows_file_system#password FsxWindowsFileSystem#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_windows_file_system#username FsxWindowsFileSystem#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
