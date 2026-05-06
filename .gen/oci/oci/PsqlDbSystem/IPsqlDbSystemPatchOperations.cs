using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IPsqlDbSystemPatchOperations), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemPatchOperations")]
    public interface IPsqlDbSystemPatchOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#operation PsqlDbSystem#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        string Operation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#selection PsqlDbSystem#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#from PsqlDbSystem#from}.</summary>
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? From
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#position PsqlDbSystem#position}.</summary>
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Position
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#selected_item PsqlDbSystem#selected_item}.</summary>
        [JsiiProperty(name: "selectedItem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SelectedItem
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#value PsqlDbSystem#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlDbSystemPatchOperations), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemPatchOperations")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlDbSystem.IPsqlDbSystemPatchOperations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#operation PsqlDbSystem#operation}.</summary>
            [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
            public string Operation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#selection PsqlDbSystem#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#from PsqlDbSystem#from}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? From
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#position PsqlDbSystem#position}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Position
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#selected_item PsqlDbSystem#selected_item}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "selectedItem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SelectedItem
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#value PsqlDbSystem#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Value
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
