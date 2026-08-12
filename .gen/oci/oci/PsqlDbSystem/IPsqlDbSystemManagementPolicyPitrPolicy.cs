using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IPsqlDbSystemManagementPolicyPitrPolicy), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemManagementPolicyPitrPolicy")]
    public interface IPsqlDbSystemManagementPolicyPitrPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/psql_db_system#restore_days PsqlDbSystem#restore_days}.</summary>
        [JsiiProperty(name: "restoreDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RestoreDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlDbSystemManagementPolicyPitrPolicy), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemManagementPolicyPitrPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyPitrPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/psql_db_system#restore_days PsqlDbSystem#restore_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restoreDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RestoreDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
