using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_idle IdentityDomainsApp#max_idle}.</summary>
        [JsiiProperty(name: "maxIdle", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxIdle
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_objects IdentityDomainsApp#max_objects}.</summary>
        [JsiiProperty(name: "maxObjects", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxObjects
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_wait IdentityDomainsApp#max_wait}.</summary>
        [JsiiProperty(name: "maxWait", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxWait
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#min_evictable_idle_time_millis IdentityDomainsApp#min_evictable_idle_time_millis}.</summary>
        [JsiiProperty(name: "minEvictableIdleTimeMillis", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinEvictableIdleTimeMillis
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#min_idle IdentityDomainsApp#min_idle}.</summary>
        [JsiiProperty(name: "minIdle", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinIdle
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_idle IdentityDomainsApp#max_idle}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxIdle", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxIdle
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_objects IdentityDomainsApp#max_objects}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxObjects", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxObjects
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_wait IdentityDomainsApp#max_wait}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxWait", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxWait
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#min_evictable_idle_time_millis IdentityDomainsApp#min_evictable_idle_time_millis}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minEvictableIdleTimeMillis", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinEvictableIdleTimeMillis
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#min_idle IdentityDomainsApp#min_idle}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minIdle", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinIdle
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
