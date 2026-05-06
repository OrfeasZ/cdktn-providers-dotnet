using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OperatorAccessControlOperatorControlAssignment
{
    [JsiiByValue(fqn: "oci.operatorAccessControlOperatorControlAssignment.OperatorAccessControlOperatorControlAssignmentTimeouts")]
    public class OperatorAccessControlOperatorControlAssignmentTimeouts : oci.OperatorAccessControlOperatorControlAssignment.IOperatorAccessControlOperatorControlAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#create OperatorAccessControlOperatorControlAssignment#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#delete OperatorAccessControlOperatorControlAssignment#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#update OperatorAccessControlOperatorControlAssignment#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
