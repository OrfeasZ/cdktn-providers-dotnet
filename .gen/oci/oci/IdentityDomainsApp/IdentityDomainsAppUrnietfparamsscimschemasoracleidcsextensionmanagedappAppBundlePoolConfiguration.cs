using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_idle IdentityDomainsApp#max_idle}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxIdle", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxIdle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_objects IdentityDomainsApp#max_objects}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxObjects", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxObjects
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_wait IdentityDomainsApp#max_wait}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxWait", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxWait
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#min_evictable_idle_time_millis IdentityDomainsApp#min_evictable_idle_time_millis}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minEvictableIdleTimeMillis", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinEvictableIdleTimeMillis
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#min_idle IdentityDomainsApp#min_idle}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minIdle", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinIdle
        {
            get;
            set;
        }
    }
}
