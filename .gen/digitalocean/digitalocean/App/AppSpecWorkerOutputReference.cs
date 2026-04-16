using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecWorkerOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecWorkerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppSpecWorkerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppSpecWorkerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecWorkerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecWorkerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAlert", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerAlert\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAlert(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecWorkerAlert[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecWorkerAlert).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecWorkerAlert).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoscaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscaling\"}}]")]
        public virtual void PutAutoscaling(digitalocean.App.IAppSpecWorkerAutoscaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerAutoscaling)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBitbucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerBitbucket\"}}]")]
        public virtual void PutBitbucket(digitalocean.App.IAppSpecWorkerBitbucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerBitbucket)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnv", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerEnv\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnv(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecWorkerEnv[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecWorkerEnv).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecWorkerEnv).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerGit\"}}]")]
        public virtual void PutGit(digitalocean.App.IAppSpecWorkerGit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerGit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithub", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerGithub\"}}]")]
        public virtual void PutGithub(digitalocean.App.IAppSpecWorkerGithub @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerGithub)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitlab", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerGitlab\"}}]")]
        public virtual void PutGitlab(digitalocean.App.IAppSpecWorkerGitlab @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerGitlab)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerImage\"}}]")]
        public virtual void PutImage(digitalocean.App.IAppSpecWorkerImage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerImage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestination\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogDestination(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecWorkerLogDestination[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecWorkerLogDestination).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecWorkerLogDestination).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTermination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerTermination\"}}]")]
        public virtual void PutTermination(digitalocean.App.IAppSpecWorkerTermination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerTermination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlert")]
        public virtual void ResetAlert()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscaling")]
        public virtual void ResetAutoscaling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBitbucket")]
        public virtual void ResetBitbucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildCommand")]
        public virtual void ResetBuildCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDockerfilePath")]
        public virtual void ResetDockerfilePath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnv")]
        public virtual void ResetEnv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentSlug")]
        public virtual void ResetEnvironmentSlug()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGit")]
        public virtual void ResetGit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithub")]
        public virtual void ResetGithub()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitlab")]
        public virtual void ResetGitlab()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImage")]
        public virtual void ResetImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceCount")]
        public virtual void ResetInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceSizeSlug")]
        public virtual void ResetInstanceSizeSlug()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogDestination")]
        public virtual void ResetLogDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunCommand")]
        public virtual void ResetRunCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDir")]
        public virtual void ResetSourceDir()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTermination")]
        public virtual void ResetTermination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "alert", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAlertList\"}")]
        public virtual digitalocean.App.AppSpecWorkerAlertList Alert
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerAlertList>()!;
        }

        [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscalingOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerAutoscalingOutputReference Autoscaling
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerAutoscalingOutputReference>()!;
        }

        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerBitbucketOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerBitbucketOutputReference Bitbucket
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerBitbucketOutputReference>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerEnvList\"}")]
        public virtual digitalocean.App.AppSpecWorkerEnvList Env
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerEnvList>()!;
        }

        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGitOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerGitOutputReference Git
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerGitOutputReference>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGithubOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerGithubOutputReference Github
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerGithubOutputReference>()!;
        }

        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGitlabOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerGitlabOutputReference Gitlab
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerGitlabOutputReference>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerImageOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerImageOutputReference Image
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerImageOutputReference>()!;
        }

        [JsiiProperty(name: "logDestination", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationList\"}")]
        public virtual digitalocean.App.AppSpecWorkerLogDestinationList LogDestination
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerLogDestinationList>()!;
        }

        [JsiiProperty(name: "termination", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerTerminationOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerTerminationOutputReference Termination
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerTerminationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alertInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AlertInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscaling\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerAutoscaling? AutoscalingInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerAutoscaling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitbucketInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerBitbucket\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerBitbucket? BitbucketInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerBitbucket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildCommandInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildCommandInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dockerfilePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DockerfilePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "envInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnvInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentSlugInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentSlugInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGithub\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerGithub? GithubInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerGithub?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGit\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerGit? GitInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerGit?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitlabInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerGitlab\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerGitlab? GitlabInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerGitlab?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerImage\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerImage? ImageInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerImage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceSizeSlugInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceSizeSlugInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logDestinationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogDestinationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runCommandInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RunCommandInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDirInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceDirInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminationInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerTermination\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerTermination? TerminationInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerTermination?>();
        }

        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildCommand
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dockerfilePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerfilePath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environmentSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentSlug
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceSizeSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceSizeSlug
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunCommand
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDir
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.app.AppSpecWorker\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.App.IAppSpecWorker cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecWorker).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
