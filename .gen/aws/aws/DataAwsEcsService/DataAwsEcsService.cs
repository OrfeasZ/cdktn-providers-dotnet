using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEcsService
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ecs_service aws_ecs_service}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsEcsService.DataAwsEcsService), fullyQualifiedName: "aws.dataAwsEcsService.DataAwsEcsService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceConfig\"}}]")]
    public class DataAwsEcsService : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ecs_service aws_ecs_service} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEcsService(Constructs.Construct scope, string id, aws.DataAwsEcsService.IDataAwsEcsServiceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsEcsService.IDataAwsEcsServiceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsService(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsEcsService resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsEcsService to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsEcsService that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsEcsService to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsEcsService to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ecs_service#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsEcsService that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsEcsService to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsEcsService.DataAwsEcsService), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsEcsService.DataAwsEcsService))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityZoneRebalancing", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZoneRebalancing
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceCapacityProviderStrategyList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceCapacityProviderStrategyList CapacityProviderStrategy
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceCapacityProviderStrategyList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationList DeploymentConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationList>()!;
        }

        [JsiiProperty(name: "deploymentController", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceDeploymentControllerList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceDeploymentControllerList DeploymentController
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceDeploymentControllerList>()!;
        }

        [JsiiProperty(name: "deployments", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceDeploymentsList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceDeploymentsList Deployments
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceDeploymentsList>()!;
        }

        [JsiiProperty(name: "desiredCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableEcsManagedTags
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableExecuteCommand", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableExecuteCommand
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "events", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceEventsList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceEventsList Events
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceEventsList>()!;
        }

        [JsiiProperty(name: "healthCheckGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckGracePeriodSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "iamRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancer", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceLoadBalancerList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceLoadBalancerList LoadBalancer
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceLoadBalancerList>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceNetworkConfigurationList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceNetworkConfigurationList NetworkConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceNetworkConfigurationList>()!;
        }

        [JsiiProperty(name: "orderedPlacementStrategy", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceOrderedPlacementStrategyList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceOrderedPlacementStrategyList OrderedPlacementStrategy
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceOrderedPlacementStrategyList>()!;
        }

        [JsiiProperty(name: "pendingCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PendingCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "placementConstraints", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServicePlacementConstraintsList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServicePlacementConstraintsList PlacementConstraints
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServicePlacementConstraintsList>()!;
        }

        [JsiiProperty(name: "platformFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PropagateTags
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runningCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RunningCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "schedulingStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchedulingStrategy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceRegistries", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceServiceRegistriesList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceServiceRegistriesList ServiceRegistries
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceServiceRegistriesList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskDefinition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taskSets", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceTaskSetsList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceTaskSetsList TaskSets
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceTaskSetsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterArnInput
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
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterArn
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

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
