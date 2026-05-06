using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOperatorAccessControlOperatorControlAssignment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/operator_access_control_operator_control_assignment oci_operator_access_control_operator_control_assignment}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOperatorAccessControlOperatorControlAssignment.DataOciOperatorAccessControlOperatorControlAssignment), fullyQualifiedName: "oci.dataOciOperatorAccessControlOperatorControlAssignment.DataOciOperatorAccessControlOperatorControlAssignment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOperatorAccessControlOperatorControlAssignment.DataOciOperatorAccessControlOperatorControlAssignmentConfig\"}}]")]
    public class DataOciOperatorAccessControlOperatorControlAssignment : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/operator_access_control_operator_control_assignment oci_operator_access_control_operator_control_assignment} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOperatorAccessControlOperatorControlAssignment(Constructs.Construct scope, string id, oci.DataOciOperatorAccessControlOperatorControlAssignment.IDataOciOperatorAccessControlOperatorControlAssignmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOperatorAccessControlOperatorControlAssignment.IDataOciOperatorAccessControlOperatorControlAssignmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOperatorAccessControlOperatorControlAssignment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOperatorAccessControlOperatorControlAssignment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOperatorAccessControlOperatorControlAssignment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOperatorAccessControlOperatorControlAssignment to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOperatorAccessControlOperatorControlAssignment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOperatorAccessControlOperatorControlAssignment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOperatorAccessControlOperatorControlAssignment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/operator_access_control_operator_control_assignment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOperatorAccessControlOperatorControlAssignment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOperatorAccessControlOperatorControlAssignment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOperatorAccessControlOperatorControlAssignment.DataOciOperatorAccessControlOperatorControlAssignment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciOperatorAccessControlOperatorControlAssignment.DataOciOperatorAccessControlOperatorControlAssignment))!;

        [JsiiProperty(name: "assignerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssignerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Comment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "detachmentDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetachmentDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ErrorCode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "errorMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutoApproveDuringMaintenance", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoApproveDuringMaintenance
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDefaultAssignment", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDefaultAssignment
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isEnforcedAlways", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnforcedAlways
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHypervisorLogForwarded", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHypervisorLogForwarded
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLogForwarded", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLogForwarded
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opControlName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpControlName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operatorControlId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatorControlId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remoteSyslogServerAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteSyslogServerAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remoteSyslogServerCaCert", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteSyslogServerCaCert
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remoteSyslogServerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RemoteSyslogServerPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "resourceCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAssignmentFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAssignmentFrom
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAssignmentTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAssignmentTo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfAssignment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfAssignment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfDeletion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfDeletion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unassignerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnassignerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validateAssignmentTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidateAssignmentTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatorControlAssignmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperatorControlAssignmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "operatorControlAssignmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatorControlAssignmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
