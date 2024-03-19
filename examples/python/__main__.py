import pulumi
import pulumi_youtrack as youtrack

my_random_resource = youtrack.Random("myRandomResource", length=24)
pulumi.export("output", {
    "value": my_random_resource.result,
})
