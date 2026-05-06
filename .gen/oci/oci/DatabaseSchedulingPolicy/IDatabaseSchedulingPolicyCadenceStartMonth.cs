using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseSchedulingPolicy
{
    [JsiiInterface(nativeType: typeof(IDatabaseSchedulingPolicyCadenceStartMonth), fullyQualifiedName: "oci.databaseSchedulingPolicy.DatabaseSchedulingPolicyCadenceStartMonth")]
    public interface IDatabaseSchedulingPolicyCadenceStartMonth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy#name DatabaseSchedulingPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseSchedulingPolicyCadenceStartMonth), fullyQualifiedName: "oci.databaseSchedulingPolicy.DatabaseSchedulingPolicyCadenceStartMonth")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseSchedulingPolicy.IDatabaseSchedulingPolicyCadenceStartMonth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy#name DatabaseSchedulingPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
