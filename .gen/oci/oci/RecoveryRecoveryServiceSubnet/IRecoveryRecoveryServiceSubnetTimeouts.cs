using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RecoveryRecoveryServiceSubnet
{
    [JsiiInterface(nativeType: typeof(IRecoveryRecoveryServiceSubnetTimeouts), fullyQualifiedName: "oci.recoveryRecoveryServiceSubnet.RecoveryRecoveryServiceSubnetTimeouts")]
    public interface IRecoveryRecoveryServiceSubnetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_recovery_service_subnet#create RecoveryRecoveryServiceSubnet#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_recovery_service_subnet#delete RecoveryRecoveryServiceSubnet#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_recovery_service_subnet#update RecoveryRecoveryServiceSubnet#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRecoveryRecoveryServiceSubnetTimeouts), fullyQualifiedName: "oci.recoveryRecoveryServiceSubnet.RecoveryRecoveryServiceSubnetTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.RecoveryRecoveryServiceSubnet.IRecoveryRecoveryServiceSubnetTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_recovery_service_subnet#create RecoveryRecoveryServiceSubnet#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_recovery_service_subnet#delete RecoveryRecoveryServiceSubnet#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_recovery_service_subnet#update RecoveryRecoveryServiceSubnet#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
