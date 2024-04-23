import * as pulumi from "@pulumi/pulumi";
import * as youtrack from "@oss4u/youtrack";

const myRandomResource = new youtrack.Random("myRandomResource", {length: 24});
export const output = {
    value: myRandomResource.result,
};
