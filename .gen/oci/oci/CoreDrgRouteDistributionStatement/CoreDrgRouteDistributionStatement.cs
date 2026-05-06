using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDrgRouteDistributionStatement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement oci_core_drg_route_distribution_statement}.</summary>
    [JsiiClass(nativeType: typeof(oci.CoreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatement), fullyQualifiedName: "oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementConfig\"}}]")]
    public class CoreDrgRouteDistributionStatement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement oci_core_drg_route_distribution_statement} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CoreDrgRouteDistributionStatement(Constructs.Construct scope, string id, oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreDrgRouteDistributionStatement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreDrgRouteDistributionStatement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CoreDrgRouteDistributionStatement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CoreDrgRouteDistributionStatement to import.</param>
        /// <param name="importFromId">The id of the existing CoreDrgRouteDistributionStatement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CoreDrgRouteDistributionStatement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CoreDrgRouteDistributionStatement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CoreDrgRouteDistributionStatement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CoreDrgRouteDistributionStatement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.CoreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putMatchCriteria", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementMatchCriteria\"}}]")]
        public virtual void PutMatchCriteria(oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementMatchCriteria @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementMatchCriteria)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.CoreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatement))!;

        [JsiiProperty(name: "matchCriteria", typeJson: "{\"fqn\":\"oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementMatchCriteriaOutputReference\"}")]
        public virtual oci.CoreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementMatchCriteriaOutputReference MatchCriteria
        {
            get => GetInstanceProperty<oci.CoreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementMatchCriteriaOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementTimeoutsOutputReference\"}")]
        public virtual oci.CoreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.CoreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "drgRouteDistributionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DrgRouteDistributionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchCriteriaInput", typeJson: "{\"fqn\":\"oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementMatchCriteria\"}", isOptional: true)]
        public virtual oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementMatchCriteria? MatchCriteriaInput
        {
            get => GetInstanceProperty<oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementMatchCriteria?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "drgRouteDistributionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DrgRouteDistributionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
